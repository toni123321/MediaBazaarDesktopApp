﻿using MediaBazaarApp.Custom_exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;
using System.Data;


namespace MediaBazaarApp
{
    public partial class AdministrationForm : Form
    {
        private bool openOtherForm = false;
        private DepartmentManagement departmentManagement;
        private Employee currentEmp;
        private StockManagement stockManagement;
        private Dictionary<string, bool> stockSotrage;
        private Dictionary<Point, bool> shortcutLocations;
        private Stock selectedStock;
        private SalesManagement salesManagement;
        private DBControl dbc;
        private AutomatedScheduleHandler ash;
        private DBControl dbControl = new DBControl();

        private double price = 0;
        private int quantity = 0;
        private double height = 0;
        private double width = 0;
        private double depth = 0;
        private double weight = 0;
        Point last;
        int afk;

        // Manager for edit account requests
        private EditAccountRequestsManager editAccountRequestsManager;
        private HLRManager hlrManager;
        private EmployeesExpiredContractManager empExpiredContractManager;


        public AdministrationForm(DepartmentManagement departmentManagement, Employee currentEmp,
            SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();

            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.stockManagement = stockManagement;
            this.stockSotrage = this.stockManagement.GetStorage();
            this.salesManagement = salesManagement;
            ash = new AutomatedScheduleHandler(departmentManagement);
            dbc = new DBControl();
            shortcutLocations = new Dictionary<Point, bool>();
            setShortcutLocationtions();
            checkForShortcuts();

            //gbChooseEmp.Visible = true;
            //.Visible = false;
            UpdateDGVStock();
            UpdateWeekNumberCB();

            RefreshWeeklyScheduleDGV(0);
            UpdateDepartmentsDGV();
            UpdateCBXDepManager(cbDepartmentManager);
            UpdateDepsManualShiftPlanning();

            //Made groupBox for editDepartment invisible
            gbxEditDepartment.Visible = false;

            // Greeting msg

            //lbGreetingMsg.Text = $"Welcome, {currentEmp.FirstName}";
            RefreshCbSelectEmpDepartment();

            EmpFillDefaultValues();

            WelcomeMessage();

            // Initializing the edit account requests manager
            editAccountRequestsManager = new EditAccountRequestsManager();
            hlrManager = new HLRManager();
            timer1.Enabled = false;
            empExpiredContractManager = new EmployeesExpiredContractManager(this.departmentManagement);

            // HLR, employees with expired contract notifications after login
            ShowHLRNotifications();
            ShowEmpExpiredContractNotifications();
        }

        public void WelcomeMessage()
        {

            string time = DateTime.Now.ToString("HH");

            if (time.StartsWith("0"))
            {
                time.Remove(0, 1);
            }

            int currentTime = Convert.ToInt32(time);


            if (currentTime >= 5 && currentTime < 12)
            {
                lbGreetingMsg.Text = $"Good morning, {currentEmp.FirstName}!";
            }
            else if (currentTime >= 12 && currentTime < 17)
            {
                lbGreetingMsg.Text = $"Have a good afternoon, {currentEmp.FirstName}";
            }
            else if (currentTime >= 17 && currentTime < 21)
            {
                lbGreetingMsg.Text = $"Have a nice evening, {currentEmp.FirstName}!";
            }
            else
            {
                lbGreetingMsg.Text = $"Good night, {currentEmp.FirstName}";
            }

            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbDateDayOfWeek.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");

        }

        private void RefreshCbSelectEmpDepartment()
        {
            cbSelectEmpDepartment.Items.Clear();
            cbSelectEmpDepartment.Items.Add("All");
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                cbSelectEmpDepartment.Items.Add(dep.Name);
            }
        }


        private void UpdateDepartmentsDGV()
        {
            var departmentsDataSource = departmentManagement.GetAllDepartments().Select(x => new
            {
                ID = x.Id,
                DepCode = x.DeptId,
                x.Name,
                Manager = x.Manager != null ? $"{x.Manager.FirstName} {x.Manager.LastName}" : "No manager",
                //Manager = $"{x.Manager.FirstName} {x.Manager.LastName}",
                NumberOfEmployees = x.GetAllEmployees().Count
            }).ToList();

            dgvDepartments.DataSource = departmentsDataSource;

            dgvDepartments.ClearSelection();
        }

        public bool CheckIsSuperuser()
        {
            bool isSuperuser = currentEmp.Email == "john@gmail.com" && currentEmp.Id == 1;

            return isSuperuser;
        }
        
        public void FillComboBoxDepartments()
        {
            cbEmpDepartment.Items.Clear();
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if (!CheckIsSuperuser() && dep.Name == "Administration")
                {
                    continue;
                }

                cbEmpDepartment.Items.Add(dep.Name);
            }

        }

        private void AdministrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!openOtherForm)
            {
                LoginForm loginForm = new LoginForm(departmentManagement, stockManagement, salesManagement);
                loginForm.Show();
            }
        }

        private void EmpFillDefaultValues()
        {
            tbxEmpFname.Text = "Test";
            tbxEmpLname.Text = "Test";
            dtpEmpDateOfBirth.Value = new DateTime(1985, 5, 12);
            cbEmpGender.Text = Gender.MALE.ToString();

            //Contact details
            tbxEmpEmail.Text = "test@gmail.com";
            tbxEmpPhone.Text = "+31 456 789 899";
            tbxEmpAddressStreet.Text = "Henderson";
            tbxEmpAddressCity.Text = "Eindhoven";
            tbxEmpAddressCountry.Text = "Netherlands";
            tbxEmpAddressPostCode.Text = "2345HK";
            tbxEmpBsn.Text = "888999777";

            //Emergency contact details
            tbxEmConName.Text = "Testing Testing";
            cbEmConRelation.Text = EmergencyContactRelation.Colleague.ToString();
            tbxEmConEmail.Text = "test456@gmail.com";
            tbxEmConPhone.Text = "0031 876 456 112";

            //Job specifications
            cbEmpEmploymentType.Text = EmploymentType.PARTTIME1.ToString();
            nudEmpHourlyWages.Text = (19).ToString();
            cbEmpDepartment.Text = "Management";
        }

        private void ClearFields()
        {
            //Personal information
            tbxEmpFname.Clear();
            tbxEmpLname.Clear();
            dtpEmpDateOfBirth.Value = DateTime.Today.Date;
            cbEmpGender.Text = "Choose gender";

            //Contact details
            tbxEmpEmail.Clear();
            tbxEmpPhone.Clear();
            tbxEmpAddressStreet.Clear();
            tbxEmpAddressCity.Clear();
            tbxEmpAddressCountry.Clear();
            tbxEmpAddressPostCode.Clear();
            tbxEmpBsn.Clear();

            //Emergency contact details
            tbxEmConName.Clear();
            cbEmConRelation.Text = "";
            tbxEmConEmail.Clear();
            tbxEmConPhone.Clear();

            //Job specifications
            cbEmpEmploymentType.Text = "";
            nudEmpHourlyWages.Value = 10;
            cbEmpDepartment.Text = "";
        }

        private bool CheckEmployeeFields()
        {
            if (!String.IsNullOrEmpty(tbxEmpFname.Text) && !String.IsNullOrEmpty(tbxEmpLname.Text) &&
                !String.IsNullOrEmpty(dtpEmpDateOfBirth.Text) && cbEmpGender.Items.Contains(cbEmpGender.Text) &&
                !String.IsNullOrEmpty(tbxEmpNationality.Text) && !String.IsNullOrEmpty(tbxEmpEmail.Text) &&
                !String.IsNullOrEmpty(tbxEmpPhone.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressStreet.Text) && !String.IsNullOrEmpty(tbxEmpAddressCity.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressCountry.Text) && !String.IsNullOrEmpty(tbxEmpAddressPostCode.Text) &&
                !String.IsNullOrEmpty(tbxEmConName.Text) && cbEmConRelation.Items.Contains(cbEmConRelation.Text) &&
                !String.IsNullOrEmpty(tbxEmConEmail.Text) && !String.IsNullOrEmpty(tbxEmConPhone.Text) &&
                !String.IsNullOrEmpty(dtpEmpStartDate.Text) && !String.IsNullOrEmpty(dtpEmpEndDate.Text) &&
                cbEmpEmploymentType.Items.Contains(cbEmpEmploymentType.Text) &&
                cbEmpDepartment.Items.Contains(cbEmpDepartment.Text))

            {
                return true;
            }

            return false;
        }

        private void btnAddEmpoyee_Click(object sender, EventArgs e)
        {
            string fname, lname;
            DateTime dateOfBirth;
            Gender gender;
            string nationality;
            DateTime startDate, endDate;

            string email, phone, street, city, country, postcode, bsn, emConName;
            EmergencyContactRelation emConRelation;
            string emConEmail, emConPhone;

            EmploymentType empType;
            int hourlyWages;
            Department department;


            if (CheckEmployeeFields())
            {
                fname = tbxEmpFname.Text;
                lname = tbxEmpLname.Text;
                dateOfBirth = dtpEmpDateOfBirth.Value;
                gender = (Gender) (Enum.Parse(typeof(Gender), cbEmpGender.SelectedItem.ToString()));
                nationality = tbxEmpNationality.Text;

                email = tbxEmpEmail.Text;
                phone = tbxEmpPhone.Text;
                street = tbxEmpAddressStreet.Text;
                city = tbxEmpAddressCity.Text;
                country = tbxEmpAddressCountry.Text;
                postcode = tbxEmpAddressPostCode.Text;
                bsn = tbxEmpBsn.Text;

                emConName = tbxEmConName.Text;
                emConRelation = (EmergencyContactRelation) Enum.Parse(typeof(EmergencyContactRelation),
                    cbEmConRelation.Text.ToString());
                emConEmail = tbxEmConEmail.Text;
                emConPhone = tbxEmConPhone.Text;

                empType = (EmploymentType) (Enum.Parse(typeof(EmploymentType),
                    cbEmpEmploymentType.SelectedItem.ToString()));

                hourlyWages = Convert.ToInt32(nudEmpHourlyWages.Text);
                startDate = dtpEmpStartDate.Value;
                endDate = dtpEmpEndDate.Value;
                if(cbxEmpIndefiniteContract.Checked)
                {
                    endDate = DateTime.MaxValue;
                }
                department = departmentManagement.GetDepartment(cbEmpDepartment.Text);


                int HLRdays = Convert.ToInt32(tbxHLRDays.Text);

                DBControl dbControl = new DBControl();

                try
                {
                    if (department.AddEmployee(departmentManagement, fname, lname, dateOfBirth, nationality, gender,
                        email, phone, street, city, country,
                        postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages,
                        startDate, endDate, department))
                    {
                        if (String.IsNullOrEmpty(bsn))
                        {
                            bsn = "999999990";
                        }

                        dbControl.AddEmployee(fname, lname, dateOfBirth, nationality, gender, email, phone, street,
                            city, country,
                            postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages,
                            startDate, endDate, department);

                        

                        dbControl.GetEmployees(this.departmentManagement);

                        Employee newEmp = departmentManagement.GetDepartment(department.Name).GetEmployeeByEmail(email);

                        if (HLRdays > 0)
                        {
                            this.dbControl.InsertRemainingHLR(HLRdays, newEmp.Id);
                        }

                        MessageBox.Show("You have successfully hired a new employee!");
                        ClearFields();
                        UpdateCBXDepManager(cbDepartmentManager);
                        RefreshEmployeesList();
                    }
                    else
                    {
                        MessageBox.Show("There is already an employee with the same email!");
                    }
                }
                catch (InputFieldException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please, fill all the fields in order to hire new employee!");
            }
        }

        public void ShowEmployeesList(List<Employee> employees)
        {
            var employeesDataSource =
                employees.Where(x => x.Email != currentEmp.Email)
                    .Select(x => new
                    {
                        ID = x.Id,
                        x.FirstName,
                        x.LastName,
                        x.Email,
                        Department = x.Department.Name

                    }).ToList();
            dgvEmployees.DataSource = employeesDataSource;

            dgvEmployees.ClearSelection();
        }

        private void tabControlEmployees_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlEmployees.SelectedTab.Name == "ManageEmpTab")
            {
                cbSelectEmpDepartment.SelectedIndex = 0;
                dbControl.GetEmployees(departmentManagement);
                ShowEmployeesList(departmentManagement.GetAllEmployees());
            }
            else if(tabControlEmployees.SelectedTab.Name  == "EmpExpiredContractTab")
            {
                gbxEmpRenewContract.Visible = false;
                ShowEmployeesWithExpiredContract(empExpiredContractManager.GetEmployeesWithExpiredContract().ToList());
            }
        }

        private void lbEmpExpiredContract_Click(object sender, EventArgs e)
        {
            tabControlAdministration.SelectedTab = EmployeesTab;
            tabControlEmployees.SelectedTab = EmpExpiredContractTab;
        }


        public void ShowEmpExpiredContractNotifications()
        {
            empExpiredContractManager.LoadDataFromStorage();
            int nrEmpWithExpiredContract = empExpiredContractManager.GetEmployeesWithExpiredContract().Count;
            panelEmpExpiredContract.Visible = nrEmpWithExpiredContract > 0;

            if (nrEmpWithExpiredContract > 0)
            {
                
                lbEmpExpiredContract.Text = nrEmpWithExpiredContract > 1 ?
                        $"There are {nrEmpWithExpiredContract} people with expired contract (click to manage)."
                        : $"There is {nrEmpWithExpiredContract} person with expired contract (click to manage).";
                
            }

        }


        //TODO: Consider the email check statement
        public void ShowEmployeesWithExpiredContract(List<Employee> employees)
        {
            var employeesWithExpiredContractDataSource =
                employees.Where(x => x.Email != currentEmp.Email)
                    .Select(x => new
                    {
                        ID = x.Id,
                        x.FirstName,
                        x.LastName,
                        x.Email,
                        Department = x.Department.Name,
                        ExpiredOn = x.EndDate

                    }).ToList();
            dgvEmployeesExpiredContract.DataSource = employeesWithExpiredContractDataSource;

            dgvEmployeesExpiredContract.ClearSelection();
        }


        private void btnEmpExpiredContractUnmarkSelected_Click(object sender, EventArgs e)
        {
            if (dgvEmployeesExpiredContract.SelectedRows.Count > 0)
            {
                dgvEmployeesExpiredContract.ClearSelection();
            }
            else
            {
                MessageBox.Show("To unmark a selected employee, choose one beforehand!");
            }
        }

        private void btnEmpRenewContract_Click(object sender, EventArgs e)
        {
            if(dgvEmployeesExpiredContract.SelectedRows.Count == 1)
            {
                int selectedEmpID = Convert.ToInt32(dgvEmployeesExpiredContract.SelectedCells[0].Value.ToString());
                Employee selectedEmp = empExpiredContractManager.GetEmployeeById(selectedEmpID);

                gbxEmpRenewContract.Visible = true;
                lbNamesEmpRenewContract.Text = $"Employee: {selectedEmp.FirstName} {selectedEmp.LastName}";
                lbEmpIdRenewContract.Text = $"Id: {selectedEmpID}";
            }
            else
            {
                MessageBox.Show("Please, choose one employee to renew their contract!");
            }
            
        }

        


        private void btnEmpSubmitChangesNewContract_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(dtpEmpStartDateNewContract.Text) && 
               (!String.IsNullOrEmpty(dtpEndDateNewContract.Text) || cbxEmpMakeNewContractIndefinite.Checked))
            {
                DateTime startDate = dtpEmpStartDateNewContract.Value;
                DateTime endDate;
                if(cbxEmpMakeNewContractIndefinite.Checked)
                {
                    endDate = DateTime.MaxValue;
                }
                else
                {
                    endDate = dtpEndDateNewContract.Value;
                }

                int empId = Convert.ToInt32(lbEmpIdRenewContract.Text.Split(' ')[1]);
                Employee emp = empExpiredContractManager.GetEmployeeById(empId);
                try
                {
                    emp.StartDate = startDate;

                    emp.EndDate = endDate;
                    empExpiredContractManager.RenewEmployeeContract(emp);

                    ShowEmployeesWithExpiredContract(empExpiredContractManager.GetEmployeesWithExpiredContract()
                        .ToList());
                    dbControl.GetEmployees(departmentManagement);

                    MessageBox.Show($"You have successfully renew contract of {emp.FirstName} {emp.LastName}");
                    gbxEmpRenewContract.Visible = false;
                }
                catch (InputFieldException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please, fill all the required boxes!\n" +
                                "Info: Start date must be provided, End date can be missed only " +
                                "if you have choosen contract to be Indefinite");
            }
        }

        private void cbSelectEmpDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBControl dbc = new DBControl();
            dbc.GetEmployees(this.departmentManagement);
            string departmentName;


            if (cbSelectEmpDepartment.SelectedItem.ToString() == "All")
            {
                ShowEmployeesList(departmentManagement.GetAllEmployees());
            }
            else
            {
                departmentName = cbSelectEmpDepartment.SelectedItem.ToString();
                ShowEmployeesList(departmentManagement.GetEmployeesByDepartment(departmentName));
            }
        }

        public void RefreshEmployeesList()
        {
            //Refresh automatically the list(show all employees)
            DBControl dbControl = new DBControl();
            dbControl.GetEmployees(this.departmentManagement);
            ShowEmployeesList(this.departmentManagement.GetAllEmployees());
            cbSelectEmpDepartment.SelectedIndex = 0;
        }

        public void RemoveDepManager(Employee selectedEmp)
        {
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if (dep.Manager != null && dep.Manager.Id == selectedEmp.Id)
                {
                    dep.Manager = null;
                }
            }
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int selectedEmpID = Convert.ToInt32(dgvEmployees.SelectedCells[0].Value.ToString());
                string selectedEmpDepName = dgvEmployees.SelectedCells[4].Value.ToString();
                Employee selectedEmp = departmentManagement.GetDepartment(selectedEmpDepName)
                    .GetEmployeeById(selectedEmpID);
                //Employee selectedEmp = (Employee)lbxAllEmployees.SelectedItem;


                //Remove selected emp locally
                if (departmentManagement.GetDepartment(selectedEmp.Department.Name).RemoveEmployee(selectedEmp.Email))
                {

                    //Remove selected employee from db
                    DBControl dbControl = new DBControl();
                    dbControl.RemoveEmployee(selectedEmp.Id);
                    MessageBox.Show($"You have successfully removed employee with id:{selectedEmp.Id}");

                    // remove manager locally
                    RemoveDepManager(selectedEmp);

                    RefreshEmployeesList();
                    UpdateCBXDepManager(cbDepartmentManager);
                    UpdateDepartmentsDGV();
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();

                }
                else
                {
                    MessageBox.Show($"There is no employee with this id: {selectedEmp.Id}");
                }
            }
            else
            {
                MessageBox.Show("Please, select an employee from the list to remove it!");
            }
        }

        private void tbxSearchEmp_TextChanged(object sender, EventArgs e)
        {
            string searchInput = tbxSearchEmp.Text;

            if (searchInput == "")
            {
                dgvDepartments.DataBindings.Clear();
            }

            List<Employee> searchResults = new List<Employee>();

            string fullname;
            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                fullname = $"{emp.FirstName} {emp.LastName}";

                if (emp.FirstName.Contains(searchInput) ||
                    emp.LastName.Contains(searchInput) ||
                    fullname.Contains(searchInput))
                {
                    searchResults.Add(emp);
                }

            }

            var employeesDataSource =
                searchResults.Where(x => x.Email != currentEmp.Email)
                    .Select(x => new
                    {
                        ID = x.Id,
                        x.FirstName,
                        x.LastName,
                        x.Email,
                        Department = x.Department.Name

                    }).ToList();

            dgvEmployees.DataSource = employeesDataSource;
            dgvEmployees.ClearSelection();
        }



        private void tbxSearchEmp_Click(object sender, EventArgs e)
        {
            // Delete default description info in search bar to let user write
            // something without needed to delete default text
            tbxSearchEmp.Text = "";
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            bool isSuperuser = false;

            if (dgvEmployees.SelectedRows.Count > 0)
            {
                if (currentEmp.Id == 1)
                {
                    isSuperuser = true;
                }

                int selectedEmpID = Convert.ToInt32(dgvEmployees.SelectedCells[0].Value.ToString());
                string selectedEmpDepName = dgvEmployees.SelectedCells[4].Value.ToString();
                Employee selectedEmp = departmentManagement.GetDepartment(selectedEmpDepName)
                    .GetEmployeeById(selectedEmpID);
                //Employee selectedEmp = (Employee)lbxAllEmployees.SelectedItem;

                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(this, departmentManagement,
                    departmentManagement.GetDepartment(selectedEmp.Department.Name)
                        .GetEmployeeByEmail(selectedEmp.Email));
                editEmployeeForm.FillComboBoxDepartments(isSuperuser);
                editEmployeeForm.Show();
            }
            else
            {
                MessageBox.Show("Please, select an employee from the list to edit their information!");
            }
        }


        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            if (StockTBXCheck() == false)
            {
                MessageBox.Show("Please fill in all text boxes before adding stock.");
            }
            else
            {
                try
                {
                    price = double.Parse(tbxStockPrice.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field price is not numeric.");
                }

                try
                {
                    quantity = int.Parse(tbxStockQuantity.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field quantity is not a whole number.");
                }

                try
                {
                    height = double.Parse(tbxStockHeight.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field height is not numeric.");
                }

                try
                {
                    width = double.Parse(tbxStockWidth.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field width is not numeric.");
                }

                try
                {
                    depth = double.Parse(tbxStockDepth.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field depth is not numeric.");
                }

                try
                {
                    weight = double.Parse(tbxStockWeight.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field weight is not numeric.");
                }

                string model = tbxStockModel.Text.ToUpper();
                string brand = tbxStockBrand.Text.ToUpper();

                string shortDescription;

                if (tbxStockShortDescription.Text == "")
                {
                    shortDescription = "No description was added";
                }
                else
                {
                    shortDescription = tbxStockShortDescription.Text;
                }

                //stockManagement.AddStock(model, brand, price, quantity, height, width, depth, weight, shortDescription);

                if (price == 0 || quantity == 0 || height == 0 || width == 0 || depth == 0 || weight == 0)
                {
                    MessageBox.Show($"Some of the fields contain invalid values. (Non-numeric or 0)");
                }
                else
                {
                    DBControl dbControl = new DBControl();
                    if (stockManagement.SearchForStock(model, brand) == null)
                    {
                        dbControl.AddStock(model, brand, price, quantity, height, width, depth, weight,
                            shortDescription, stockManagement);
                    }
                    else
                    {
                        Stock stock = stockManagement.SearchForStock(model, brand);
                        stock.Quantity += quantity;
                        dbControl.UpdateStockQuantity(stock);
                    }

                    dbControl.GetStocks(this.stockManagement);

                    ClearStockTbx();
                }


            }

            UpdateDGVStock();


        }

        private void BtnShowAllStocks_Click(object sender, EventArgs e)
        {
            UpdateDGVStock();
        }


        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStock.SelectedCells[0].Value.ToString());

            selectedStock = stockManagement.GetStock(id);

            if (selectedStock != null)
            {
                RemoveStockForm removeStockForm = new RemoveStockForm(this);
                removeStockForm.Show();
            }
            else
            {
                MessageBox.Show("Please select the stock you wish to remove.");
            }
        }

        private void BtnEditStock_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStock.SelectedCells[0].Value.ToString());

            selectedStock = stockManagement.GetStock(id);

            if (selectedStock != null)
            {
                EditStockForm editStockForm = new EditStockForm(this);
                editStockForm.Show();
            }
            else
            {
                MessageBox.Show("Please select the stock you wish to edit");
            }
        }

        private void ClearStockTbx()
        {
            tbxStockBrand.Clear();
            tbxStockModel.Clear();
            tbxStockPrice.Clear();
            tbxStockDepth.Clear();
            tbxStockQuantity.Clear();
            tbxStockHeight.Clear();
            tbxStockWeight.Clear();
            tbxStockWidth.Clear();
            tbxStockShortDescription.Clear();
        }

        private bool StockTBXCheck()
        {
            if (tbxStockModel.Text == "" || tbxStockBrand.Text == "" || tbxStockPrice.Text == "" ||
                tbxStockQuantity.Text == "" || tbxStockWeight.Text == "" || tbxStockWidth.Text == "" ||
                tbxStockHeight.Text == "" || tbxStockDepth.Text == "")
            {
                return false;
            }

            return true;

        }

        public Stock GetSelectedStock()
        {
            return selectedStock;
        }

        public StockManagement GetStockManagement()
        {
            return stockManagement;
        }






        private void lbxScheduleAllEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = null;
            DBControl dbc = new DBControl();

            emp = (Employee) cbEmps.SelectedItem;
            dbc.GetShifts(departmentManagement);

          //  lbxSelectedEmpShifts.Items.Clear();

            if (emp.GetAllShifts() != null)
            {
                foreach (Shift s in emp.GetAllShifts())
                {
                   // lbxSelectedEmpShifts.Items.Add(s);
                }
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
           // Shift shift = (Shift) lbxSelectedEmpShifts.SelectedItem;
            //Employee emp = (Employee) cbEmps.SelectedItem;

            DBControl dbc = new DBControl();

            //if (shift != null)
            //{
            //    dbc.RemoveShift(shift);
            //    dbc.GetShifts(departmentManagement);

            //    emp.RemoveShift(shift.ID); // to improve

            //    dbc.GetShifts(departmentManagement);
            //    UpdateShiftsPerEmployee();
            //}
        }

        private List<Employee> GetDepManagers()
        {
            List<Employee> managers = new List<Employee>();
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                managers.Add(dep.Manager);
            }

            return managers;
        }

        private List<Employee> GetNotManagers()
        {
            List<Employee> notManagers = new List<Employee>();
            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (!GetDepManagers().Contains(emp))
                {
                    notManagers.Add(emp);
                }
            }

            return notManagers;
        }

        public void UpdateCBXDepManager(ComboBox cbx)
        {
            cbx.Items.Clear();
            foreach (Employee emp in GetNotManagers())
            {
                cbx.Items.Add(emp);
            }
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            string depName;
            Employee manager;
            DBControl dbControl = new DBControl();

            if (!String.IsNullOrEmpty(tbxDepartmentName.Text))
            {
                try
                {
                    depName = tbxDepartmentName.Text;
                    if (departmentManagement.AddDepartment(depName))
                    {

                        if (cbDepartmentManager.SelectedIndex != -1)
                        {
                            //dep with manager
                            manager = (Employee) cbDepartmentManager.SelectedItem;
                            //add locally and catch exceptions

                            //add to DB
                            dbControl.AddDepartment(depName, manager);
                            dbControl.GetDepartments(this.departmentManagement);
                            dbControl.SetDepartmentManagers(this.departmentManagement);
                        }
                        else
                        {
                            //add locally and catch exceptions

                            //add to DB
                            // dep without manager for now
                            dbControl.AddDepartment(depName);
                            dbControl.GetDepartments(this.departmentManagement);

                        }

                        UpdateDepartmentsDGV();
                        tbxDepartmentName.Clear();
                        UpdateCBXDepManager(cbDepartmentManager);
                        cbDepartmentManager.Text = "Choose a manager";
                        MessageBox.Show("You have successfully created new department!");
                        RefreshCbSelectEmpDepartment();
                        FillComboBoxDepartments();
                    }
                    else
                    {
                        MessageBox.Show($"Department with the same name: {depName} already exists!");
                    }
                }
                catch (DepNameException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill at least the name to create new department!");
            }

        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvDepartments.SelectedCells[0].Value.ToString());
                Department dep = departmentManagement.GetDepartment(id);

                DBControl dbControl = new DBControl();

                if (dep.GetAllEmployees().Count == 0)
                {
                    dbControl.RemoveDepartment(dep.Name);
                    departmentManagement.RemoveDepartment(dep.Name);
                    //dbControl.GetDepartments(this.departmentManagement);
                    MessageBox.Show($"You have successfully removed department with name:{dep.Name}");

                    UpdateDepartmentsDGV();
                    UpdateCBXDepManager(cbDepartmentManager);
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();

                    //refresh employee list
                    RefreshEmployeesList();
                }
                else
                {
                    MessageBox.Show("This department can't be deleted, because has employees!");
                }

                /*if (dep.GetAllEmployees().Count > 0)
                {
                    RemoveDepartmentForm removeDepartmentForm = new RemoveDepartmentForm(this, dep);
                    removeDepartmentForm.Show();
                }
                else
                {
                    DBControl dbControl = new DBControl();
                    dbControl.RemoveDepartment(dep.Name);
                    departmentManagement.RemoveDepartment(dep.Name);
                    //dbControl.GetDepartments(this.departmentManagement);
                    MessageBox.Show($"You have successfully removed branch with name:{dep.Name}");
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();
                }*/
            }
            else
            {
                MessageBox.Show("Please, select an department to remove it!");
            }
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDepartments.SelectedCells[0].Value.ToString());
                Department dep = departmentManagement.GetDepartment(id);

                tbxDepartmentNameEdit.Text = dep.Name;
                UpdateCBXDepManager(cbDepartmentManagerEdit);
                if (dep.Manager != null)
                {
                    lbDepartmentCurrManagerEdit.Text = $"Current manager:{dep.Manager}";
                    cbDepartmentManagerEdit.Items.Add(dep.Manager);
                    cbDepartmentManagerEdit.SelectedIndex = cbDepartmentManagerEdit.Items.Count - 1;
                }
                else
                {
                    lbDepartmentCurrManagerEdit.Text = $"Current manager: there is no manager";
                }

                lbDepartmentEditInfo.Text = $"Department with Id:{dep.Id}";
                gbxEditDepartment.Visible = true;

            }
            else
            {
                MessageBox.Show("Please, select an department to edit it!");
            }
        }

        private void btnApplyChangesDepartment_Click(object sender, EventArgs e)
        {
            int depId = Convert.ToInt32(lbDepartmentEditInfo.Text.Split(':')[1]);
            Department dep = departmentManagement.GetDepartment(depId);
            string newName;
            Employee manager;

            DBControl dbControl = new DBControl();

            if (!String.IsNullOrEmpty(tbxDepartmentNameEdit.Text))
            {
                try
                {
                    newName = tbxDepartmentNameEdit.Text;
                    if (cbDepartmentManagerEdit.SelectedIndex != -1)
                    {
                        manager = (Employee) cbDepartmentManagerEdit.SelectedItem;
                        //Update department locally and catch exceptions
                        dep.Name = newName;
                        //Update department into DB
                        dbControl.UpdateDepartment(depId, newName, manager.Id);
                    }
                    else
                    {
                        dep.Name = newName;
                        if (dep.Manager != null)
                        {
                            int newIdManager = -1; // means the manager is removed
                            dep.Name = newName; // update dep name locally
                            dep.Manager = null; // update dep manager locally
                            dbControl.UpdateDepartment(depId, newName, newIdManager);
                        }
                        else
                        {
                            dep.Name = newName; // update dep name locally
                            dbControl.UpdateDepartment(depId, newName);
                        }
                    }

                    //departmentManagement.RemoveDepartment(dep.Name);

                    dbControl.GetDepartments(departmentManagement);
                    dbControl.SetDepartmentManagers(departmentManagement);

                    MessageBox.Show("The new changes are successfully applied!");
                    tbxDepartmentNameEdit.Clear();
                    cbDepartmentManagerEdit.Text = "Choose a manager";
                    gbxEditDepartment.Visible = false;

                    UpdateDepartmentsDGV();
                    UpdateCBXDepManager(cbDepartmentManager);
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();

                    //refresh employee list
                    RefreshEmployeesList();
                }
                catch (DepNameException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please, fill the text box to apply changes!");
            }
        }

        private void btnDepartmentsClearSelected_Click(object sender, EventArgs e)
        {
            dgvDepartments.ClearSelection();

        }

        private void btnClearSelectedEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                dgvEmployees.ClearSelection();
            }
            else
            {
                MessageBox.Show("To unmark a selected employee, choose one beforehand!");
            }
        }


        private void tbxSearchDep_Click(object sender, EventArgs e)
        {

            // Delete default description info in search bar to let user write
            // something without needed to delete default text
            tbxSearchDep.Text = "";
        }

        private void btnShowAllDep_Click(object sender, EventArgs e)
        {
            UpdateDepartmentsDGV();
        }

        private void tabControlAdministration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdministration.SelectedTab == ManageDepartmentsTab)
            {
                UpdateCBXDepManager(cbDepartmentManager);
            }
            else if (tabControlAdministration.SelectedTab == tabPageEditAccountRequests)
            {
                cbFilterEditAccountRequests.SelectedIndex = 0;
                UpdateDGVEditAccountRequests(editAccountRequestsManager.GetAllEditAccountRequests());
            }
            else if (tabControlAdministration.SelectedTab == HomeTab)
            {
                ShowHLRNotifications();
                ShowEmpExpiredContractNotifications();
            }
        }



        private void UpdateDepsManualShiftPlanning()
        {
            cbDeps.Items.Clear();
            cbAllDeps.Items.Clear();

            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                cbDeps.Items.Add(dep.Name);
                cbAllDeps.Items.Add(dep.Name);
            }
        }

       

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbShiftType.SelectedIndex < 0)
            {
                throw new NotAllFieldFilled();
            }
            else
            {
                Employee selectedEmp = (Employee) cbEmps.SelectedItem;
                bool wfh;
                ShiftType type = new ShiftType();
                DateTime date = dtpShiftDate.Value;

                if (cbWFH.Checked)
                {
                    wfh = true;
                }
                else
                {
                    wfh = false;
                }

                if (cbShiftType.SelectedIndex == 0)
                {
                    type = ShiftType.Morning;
                }
                else if (cbShiftType.SelectedIndex == 1)
                {
                    type = ShiftType.Afternoon;
                }
                else if (cbShiftType.SelectedIndex == 2)
                {
                    type = ShiftType.Evening;
                }

                cbEmps.SelectedIndex = -1;
                dtpShiftDate.Value = DateTime.Today;
                cbWFH.Checked = false;
                cbShiftType.SelectedIndex = -1;

                MessageBox.Show($"You have added a new shift for {selectedEmp.FirstName} {selectedEmp.LastName}");

                dbc.AddShift(type, date, currentEmp.Id, wfh, selectedEmp);

                dbc.GetShifts(departmentManagement);
            }


        }

      

        private void UpdateShiftsPerEmployee()
        {
           // lbxSelectedEmpShifts.Items.Clear();

            Employee selectedEmp = (Employee) cbEmps.SelectedItem;

            foreach (Shift s in selectedEmp.GetAllShifts())
            {
               // lbxSelectedEmpShifts.Items.Add(s);
            }
        }

        private void btnScheduleClearSelected_Click_1(object sender, EventArgs e)
        {
           // lbxSelectedEmpShifts.SelectedIndex = -1;
        }

        private void cbSelectedEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmp = (Employee) cbSelectedEmp.SelectedItem;

            cbEmployeesShifts.Items.Clear();

            foreach (Shift s in selectedEmp.GetAllShifts())
            {
                cbEmployeesShifts.Items.Add(s);
            }

            dbc.GetShifts(departmentManagement);
        }

        private void cbAllDeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSelectedEmp.Items.Clear();

            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (emp.Department.Name == cbAllDeps.SelectedItem)
                {
                    cbSelectedEmp.Items.Add(emp);
                }
            }

            dbc.GetShifts(departmentManagement);
        }


        private void cbEmployeesShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shift selectedShift = (Shift) cbEmployeesShifts.SelectedItem;

            if (selectedShift != null)
            {
                lbHasAttended.Visible = true;
                lbReason.Visible = true;
                cbHasAttended.Visible = true;
                tbReasonForAbsence.Visible = true;

                if (selectedShift.HasAttended == false)
                {
                    cbHasAttended.Checked = false;
                    tbReasonForAbsence.Text = selectedShift.NoShowReason;
                }
                else
                {
                    cbHasAttended.Checked = true;
                    tbReasonForAbsence.Text = null;
                }

            }

            dbc.GetShifts(departmentManagement);
        }

        private void btnApplyAttendanceChanges_Click(object sender, EventArgs e)
        {
            Shift selectedShift = (Shift) cbEmployeesShifts.SelectedItem;
            bool attended;

            if (selectedShift != null)
            {

                if (cbHasAttended.Checked)
                {
                    attended = true;
                    selectedShift.HasAttended = true;
                    selectedShift.NoShowReason = "";
                }
                else
                {
                    attended = false;
                    selectedShift.HasAttended = false;
                    selectedShift.NoShowReason = tbReasonForAbsence.Text;
                }

                lbHasAttended.Visible = false;
                lbReason.Visible = false;
                cbHasAttended.Visible = false;
                tbReasonForAbsence.Visible = false;

                cbAllDeps.SelectedIndex = -1;
                cbSelectedEmp.SelectedIndex = -1;

                dbc.EditShiftAttendance(attended, tbReasonForAbsence.Text, selectedShift.ID);
                dbc.GetShifts(departmentManagement);
                //RefreshWeeklySchedule();
                UpdateDepsManualShiftPlanning();

            }
        }

        private void RefreshWeeklyScheduleDGV(int week)
        {
            if (week < 1)
            {
                week = (int)GetIso8601WeekOfYear(DateTime.Now);
            }

            dgvSchedule.Rows.Clear();
            dbc.GetShifts(departmentManagement);

            if (cbFilterAttended.Checked == true && cbFilterWFH.Checked == true)
            {
                foreach (Employee emp in departmentManagement.GetAllEmployees())
                {
                    foreach (Shift s in emp.GetAllShifts())
                    {
                        if (GetIso8601WeekOfYear(s.Date) == week && s.HasAttended == true && s.WFH == true)
                        {
                            object[] RowValues = { "", "", "", "", "", "", "", "" };

                            RowValues[0] = s.ID;
                            RowValues[1] = $"{emp.FirstName} {emp.LastName}";
                            RowValues[2] = s.Date.ToString("dd/MM/yyyy");
                            RowValues[3] = s.Type;
                            RowValues[4] = s.WFH;
                            RowValues[5] = $"{departmentManagement.GetEmployeeById(s.AssignedBy).FirstName} {departmentManagement.GetEmployeeById(s.AssignedBy).LastName}";
                            RowValues[6] = s.HasAttended;
                            RowValues[7] = s.NoShowReason;

                            dgvSchedule.Rows.Add(RowValues);
                        }
                    }
                }
            }
            else if (cbFilterAttended.Checked == true)
            {
                foreach (Employee emp in departmentManagement.GetAllEmployees())
                {
                    foreach (Shift s in emp.GetAllShifts())
                    {
                        if (GetIso8601WeekOfYear(s.Date) == week && s.HasAttended == true)
                        {
                            object[] RowValues = { "", "", "", "", "", "", "", "" };

                            RowValues[0] = s.ID;
                            RowValues[1] = $"{emp.FirstName} {emp.LastName}";
                            RowValues[2] = s.Date.ToString("dd/MM/yyyy");
                            RowValues[3] = s.Type;
                            RowValues[4] = s.WFH;
                            RowValues[5] = $"{departmentManagement.GetEmployeeById(s.AssignedBy).FirstName} {departmentManagement.GetEmployeeById(s.AssignedBy).LastName}";
                            RowValues[6] = s.HasAttended;
                            RowValues[7] = s.NoShowReason;

                            dgvSchedule.Rows.Add(RowValues);
                        }
                    }
                }
            }
            else if (cbFilterWFH.Checked == true)
            {
                foreach (Employee emp in departmentManagement.GetAllEmployees())
                {
                    foreach (Shift s in emp.GetAllShifts())
                    {
                        if (GetIso8601WeekOfYear(s.Date) == week && s.WFH == true)
                        {
                            object[] RowValues = { "", "", "", "", "", "", "", "" };

                            RowValues[0] = s.ID;
                            RowValues[1] = $"{emp.FirstName} {emp.LastName}";
                            RowValues[2] = s.Date.ToString("dd/MM/yyyy");
                            RowValues[3] = s.Type;
                            RowValues[4] = s.WFH;
                            RowValues[5] = $"{departmentManagement.GetEmployeeById(s.AssignedBy).FirstName} {departmentManagement.GetEmployeeById(s.AssignedBy).LastName}";
                            RowValues[6] = s.HasAttended;
                            RowValues[7] = s.NoShowReason;

                            dgvSchedule.Rows.Add(RowValues);
                        }
                    }
                }
            }
            else
            {
                foreach (Employee emp in departmentManagement.GetAllEmployees())
                {
                    foreach (Shift s in emp.GetAllShifts())
                    {
                        if (GetIso8601WeekOfYear(s.Date) == week)
                        {
                            object[] RowValues = { "", "", "", "", "", "", "", "" };

                            RowValues[0] = s.ID;
                            RowValues[1] = $"{emp.FirstName} {emp.LastName}";
                            RowValues[2] = s.Date.ToString("dd/MM/yyyy");
                            RowValues[3] = s.Type;
                            RowValues[4] = s.WFH;
                            RowValues[5] = $"{departmentManagement.GetEmployeeById(s.AssignedBy).FirstName} {departmentManagement.GetEmployeeById(s.AssignedBy).LastName}";
                            RowValues[6] = s.HasAttended;
                            RowValues[7] = s.NoShowReason;

                            dgvSchedule.Rows.Add(RowValues);
                        }
                    }
                }
            }

            
        }

        private void UpdateWeekNumberCB()
        {
            for (int i = 1; i <= 52; i++)
            {
                cbWeekNumber.Items.Add(i);
            }
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
        }

        private void cbWeekNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int week;

            if (cbWeekNumber.SelectedIndex != -1)
            {
                week = (int)cbWeekNumber.SelectedItem;
            }
            else
            {
                week = GetIso8601WeekOfYear(DateTime.Now);
            }
            

            RefreshWeeklyScheduleDGV(week);
        }

        private void cbDeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEmps.Items.Clear();

            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (emp.Department.Name == cbDeps.SelectedItem)
                {
                    cbEmps.Items.Add(emp);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WelcomeMessage();

            Point current = Cursor.Position;
            if (current == last)
            {
                afk++;
                if (afk == 900)
                {
                    MessageBox.Show("You have been logged out due to being idle. Please, log in again.");
                    afk = 0;
                    this.Close();
                }
            }

            last = Cursor.Position;
        }

        private void GoToManageEmp()
        {
            tabControlAdministration.SelectedTab = EmployeesTab;
            tabControlEmployees.SelectedTab = ManageEmpTab;
        }

        private void GoToHolidayLeaveRequests()
        {
            tabControlAdministration.SelectedTab = EmployeesTab;
            tabControlEmployees.SelectedTab = HolidayRequestsTab;
        }

        private void GoToWeeklySchedule()
        {
            tabControlAdministration.SelectedTab = SchedulingTab;
            tabControl1.SelectedTab = tbWeeklySchedule;
        }

        private void GoToManageAttendance()
        {
            tabControlAdministration.SelectedTab = SchedulingTab;
            tabControl1.SelectedTab = tpManageAttendance;
        }

        private void GoToManageStock()
        {
            tabControlAdministration.SelectedTab = StocksTab;
            tabControlStocks.SelectedTab = ManageStocksTab;
        }

        private void GoToManageDepartments()
        {
            tabControlAdministration.SelectedTab = ManageDepartmentsTab;
        }

        private void ManageEmpShortcut_Click(object sender, EventArgs e)
        {
            GoToManageEmp();
        }

        private void ManageEmpPic_Click(object sender, EventArgs e)
        {
            GoToManageEmp();
        }

        private void ManageEmpLBL_Click(object sender, EventArgs e)
        {
            GoToManageEmp();
        }

        private void HolidayLeaveRequestsShortcut_Click(object sender, EventArgs e)
        {
            GoToHolidayLeaveRequests();
        }

        private void HolidayLeavePic_Click(object sender, EventArgs e)
        {
            GoToHolidayLeaveRequests();
        }

        private void HolidayLeaveLBL_Click(object sender, EventArgs e)
        {
            GoToHolidayLeaveRequests();
        }

        private void WeeklySchedukeShortcut_Click(object sender, EventArgs e)
        {
            GoToWeeklySchedule();
        }

        private void WeekSchedulePic_Click(object sender, EventArgs e)
        {
            GoToWeeklySchedule();
        }

        private void WeeklyScheduleLBL_Click(object sender, EventArgs e)
        {
            GoToWeeklySchedule();
        }

        private void ManageAttendanceShortcut_Click(object sender, EventArgs e)
        {
            GoToManageAttendance();
        }

        private void ManageAttendancePic_Click(object sender, EventArgs e)
        {
            GoToManageAttendance();
        }

        private void ManageAttendanceLBL_Click(object sender, EventArgs e)
        {
            GoToManageAttendance();
        }

        private void ManageStockShortcut_Click(object sender, EventArgs e)
        {
            GoToManageStock();
        }

        private void ManageStockPic_Click(object sender, EventArgs e)
        {
            GoToManageStock();
        }

        private void ManageStockLBL_Click(object sender, EventArgs e)
        {
            GoToManageStock();
        }

        private void ManageDepartmentsShortcut_Click(object sender, EventArgs e)
        {
            GoToManageDepartments();
        }

        private void ManageDepPic_Click(object sender, EventArgs e)
        {
            GoToManageDepartments();
        }

        private void ManageDepLBL_Click(object sender, EventArgs e)
        {
            GoToManageDepartments();
        }

        

        public void UpdateDGVStock()
        {
            var stockDataSource = stockManagement.GetAllStocks().Select(x => new
            {
                ID = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                Quantity = x.Quantity,
                Price = x.Price,
                Width = x.Width,
                Height = x.Height,
                Depth = x.Depth,
                Weight = x.Weight,
                Description = x.ShortDescription != null ? $"{x.ShortDescription}" : "n/a",
                Location = x.Location != null ? $"{x.Location}" : "n/a",
                Disontinued=x.Discontinued
            }).ToList();

            dgvStock.DataSource = stockDataSource;

            dgvStock.ClearSelection();

        }

        private void tbxSearchStock_TextChanged(object sender, EventArgs e)
        {
            string searchInput = tbxSearchStock.Text;

            if (searchInput == "")
            {
                dgvStock.DataBindings.Clear();
            }

            List<Stock> searchResults = new List<Stock>();

            foreach (Stock s in stockManagement.GetAllStocks())
            {
                if (s.Model.Contains(searchInput) || s.Brand.Contains(searchInput) ||
                    Convert.ToString(s.Id) == searchInput)
                {
                    searchResults.Add(s);
                }
            }

            var stockDataSource = searchResults.Select(x => new
            {
                ID = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                Quantity = x.Quantity,
                Price = x.Price,
                Width = x.Width,
                Height = x.Height,
                Depth = x.Depth,
                Weight = x.Weight,
                Description = x.ShortDescription != null ? $"{x.ShortDescription}" : "n/a",
                Location = x.Location != null ? $"{x.Location}" : "n/a"
            }).ToList();

            dgvStock.DataSource = stockDataSource;


        }

        private void btnStocksClearSelected_Click(object sender, EventArgs e)
        {
            dgvStock.ClearSelection();
        }

        private void setShortcutLocationtions()
        {
            shortcutLocations.Add(new Point(704, 102), true);
            shortcutLocations.Add(new Point(704, 188), true);
            shortcutLocations.Add(new Point(704, 275), true);
            shortcutLocations.Add(new Point(704, 362), true);
            shortcutLocations.Add(new Point(704, 448), true);
            shortcutLocations.Add(new Point(704, 535), true);
        }

        private void checkForShortcuts()
        {
            manageEmpShortcut.Visible = false;
            holidayLeaveRequestsShortcut.Visible = false;
            weeklySchedukeShortcut.Visible = false;
            manageAttendanceShortcut.Visible = false;
            manageStockShortcut.Visible = false;
            manageDepartmentsShortcut.Visible = false;


            List<Panel> allShortcuts = new List<Panel>();

            allShortcuts.Add(manageEmpShortcut);
            allShortcuts.Add(holidayLeaveRequestsShortcut);
            allShortcuts.Add(weeklySchedukeShortcut);
            allShortcuts.Add(manageAttendanceShortcut);
            allShortcuts.Add(manageStockShortcut);
            allShortcuts.Add(manageDepartmentsShortcut);

            List<string> shortcutsSTR = dbc.GetActivatedShortcuts(currentEmp);
            List<Point> keys = new List<Point>(shortcutLocations.Keys);

            foreach (Point k in keys)
            {
                shortcutLocations[k] = true;
            }

            foreach (Panel s in allShortcuts)
            {
                if (shortcutsSTR.Contains(s.Name))
                {
                    activateShortCut(s);
                    if (s.Name == manageEmpShortcut.Name)
                    {
                        manageEmpCH.Checked = true;
                    }
                    else if (s.Name == holidayLeaveRequestsShortcut.Name)
                    {
                        holidayLeaveReqCH.Checked = true;
                    }
                    else if (s.Name == weeklySchedukeShortcut.Name)
                    {
                        weeklyScheduleCH.Checked = true;
                    }
                    else if (s.Name == manageAttendanceShortcut.Name)
                    {
                        manageAttendanceCH.Checked = true;
                    }
                    else if (s.Name == manageStockShortcut.Name)
                    {
                        manageStockCH.Checked = true;
                    }
                    else if (s.Name == manageDepartmentsShortcut.Name)
                    {
                        manageDepCH.Checked = true;
                    }
                }
            }
        }

        private void activateShortCut(Panel shortcut)
        {
            Point location = shortcut.Location;
            shortcutLocations[location] = true;
            shortcut.Visible = false;
            dbc.RemoveShortcut(currentEmp, shortcut.Name);
            List<Point> keys = new List<Point>(shortcutLocations.Keys);
            foreach (Point k in keys)
            {
                if (shortcutLocations[k] == true)
                {
                    shortcut.Location = k;
                    shortcut.Visible = true;
                    shortcutLocations[k] = false;
                    dbc.SaveShortcut(currentEmp, shortcut.Name);
                    break;
                }
            }
        }

        private void ApplyShortcutsBTN_Click(object sender, EventArgs e)
        {
            if (manageEmpCH.Checked == false)
            {
                manageEmpShortcut.Visible = false;
                Point location = manageEmpShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, manageEmpShortcut.Name);
            }

            if (holidayLeaveReqCH.Checked == false)
            {
                holidayLeaveRequestsShortcut.Visible = false;
                Point location = holidayLeaveRequestsShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, holidayLeaveRequestsShortcut.Name);
            }

            if (weeklyScheduleCH.Checked == false)
            {
                weeklySchedukeShortcut.Visible = false;
                Point location = weeklySchedukeShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, weeklySchedukeShortcut.Name);
            }

            if (manageAttendanceCH.Checked == false)
            {
                manageAttendanceShortcut.Visible = false;
                Point location = manageAttendanceShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, manageAttendanceShortcut.Name);
            }

            if (manageStockCH.Checked == false)
            {
                manageStockShortcut.Visible = false;
                Point location = manageStockShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, manageStockShortcut.Name);
            }

            if (manageDepCH.Checked == false)
            {
                manageDepartmentsShortcut.Visible = false;
                Point location = manageDepartmentsShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, manageDepartmentsShortcut.Name);
            }

            if (manageEmpCH.Checked)
            {
                activateShortCut(manageEmpShortcut);
            }

            if (holidayLeaveReqCH.Checked)
            {
                activateShortCut(holidayLeaveRequestsShortcut);
            }

            if (weeklyScheduleCH.Checked)
            {
                activateShortCut(weeklySchedukeShortcut);
            }

            if (manageAttendanceCH.Checked)
            {
                activateShortCut(manageAttendanceShortcut);
            }

            if (manageStockCH.Checked)
            {
                activateShortCut(manageStockShortcut);
            }

            if (manageDepCH.Checked)
            {
                activateShortCut(manageDepartmentsShortcut);
            }

        }

        private void tbxSearchDep_TextChanged(object sender, EventArgs e)
        {
            string searchInput = tbxSearchDep.Text;

            if (searchInput == "")
            {
                dgvDepartments.DataBindings.Clear();
            }

            List<Department> searchResults = new List<Department>();

            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if (Convert.ToString(dep.Id) == searchInput || dep.Name.Contains(searchInput))
                {
                    searchResults.Add(dep);
                }
            }

            var departmentDataSource = searchResults.Select(x => new
            {
                ID = x.Id,
                DepCode = x.DeptId,
                x.Name,
                Manager = x.Manager != null ? $"{x.Manager.FirstName} {x.Manager.LastName}" : "No manager",
                //Manager = $"{x.Manager.FirstName} {x.Manager.LastName}",
                NumberOfEmployees = x.GetAllEmployees().Count
            }).ToList();

            dgvDepartments.DataSource = departmentDataSource;
            dgvDepartments.ClearSelection();
        }

        public void UpdateDGVEditAccountRequests(IList<EditAccountRequest> requests)
        {
            var editAccountRequestsDataSource =
                requests.Select(x => new
                {
                    ID = x.Id,
                    x.Email,
                    x.PhoneNumber,
                    x.Street,
                    x.City,
                    x.Country,
                    x.Postcode,
                    EmergencyContactName = x.EmConName,
                    EmergencyContactRelation = x.EmConRelation,
                    EmergencyContactEmail = x.EmConEmail,
                    EmergencyContactPhone = x.EmConPhone,
                    x.Status,
                    x.RequestDate
                }).ToList();
            dgvEditAccountRequests.DataSource = editAccountRequestsDataSource;
            dgvEditAccountRequests.ClearSelection();
        }

        private void btnAcceptEditAccountRequest_Click(object sender, EventArgs e)
        {
            if (dgvEditAccountRequests.SelectedRows.Count == 1)
            {
                int requestId = Convert.ToInt32(dgvEditAccountRequests.SelectedCells[0].Value);
                EditAccountRequest curRequest = editAccountRequestsManager.GetEditAccountRequest(requestId);

                if (curRequest.Status != "InProgress")
                {
                    MessageBox.Show("This request is already processed!");
                }
                else
                {
                    editAccountRequestsManager.AcceptRequest(curRequest, this.departmentManagement);
                    cbFilterEditAccountRequests.SelectedIndex = 0;
                    UpdateDGVEditAccountRequests(editAccountRequestsManager.GetAllEditAccountRequests());
                    MessageBox.Show("You have accepted this request!");
                }
            }
            else
            {
                MessageBox.Show("Please, select a request to mark it as /Accepted/");
            }
        }

        private void btnDeclineEditAccountRequest_Click(object sender, EventArgs e)
        {
            if (dgvEditAccountRequests.SelectedRows.Count == 1)
            {
                int requestId = Convert.ToInt32(dgvEditAccountRequests.SelectedCells[0].Value);

                EditAccountRequest curRequest = editAccountRequestsManager.GetEditAccountRequest(requestId);

                if (curRequest.Status != "InProgress")
                {
                    MessageBox.Show("This request is already processed!");
                }
                else
                {
                    editAccountRequestsManager.DeclineRequest(curRequest, this.departmentManagement);
                    cbFilterEditAccountRequests.SelectedIndex = 0;
                    
                    UpdateDGVEditAccountRequests(editAccountRequestsManager.GetAllEditAccountRequests());
                    MessageBox.Show("You have declined this request!");
                }
            }
            else
            {
                MessageBox.Show("Please, select a request to mark it as /Declined/");
            }
        }

        private void cbFilterEditAccountRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cbFilterEditAccountRequests.SelectedItem.ToString();
            switch (status)
            {
                case "All":
                    UpdateDGVEditAccountRequests(editAccountRequestsManager.GetAllEditAccountRequests());
                    break;
                case "Accepted":
                    UpdateDGVEditAccountRequests(editAccountRequestsManager.GetAcceptedEditAccountRequests());
                    break;
                case "Declined":
                    UpdateDGVEditAccountRequests(editAccountRequestsManager.GetDeclinedEditAccountRequests());
                    break;
                case "InProgress":
                    UpdateDGVEditAccountRequests(editAccountRequestsManager.GetInProgressEditAccountRequests());
                    break;
            }
        }

        private void btnUnmarkSelectedEditAccountRequest_Click(object sender, EventArgs e)
        {
            if (dgvEditAccountRequests.SelectedRows.Count == 1)
            {
                dgvEditAccountRequests.ClearSelection();
            }
            else
            {
                MessageBox.Show("To unmark request, you should have selected one beforehand!");
            }
        }


        private void tabControlEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlEmployees.SelectedTab == HolidayRequestsTab)
            {
                cbFilterHLR.SelectedIndex = 0;
                UpdateDGVHLR(hlrManager.GetAllRequests());
            }
        }
        // HLR


        private void cbFilterHLR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cbFilterHLR.SelectedItem.ToString();
            switch (status)
            {
                case "All":
                    UpdateDGVHLR(hlrManager.GetAllRequests());
                    break;
                case "Accepted":
                    UpdateDGVHLR(hlrManager.GetAcceptedRequests());
                    break;
                case "Declined":
                    UpdateDGVHLR(hlrManager.GetDeclinedRequests());
                    break;
                case "InProgress":
                    UpdateDGVHLR(hlrManager.GetPendingRequests());
                    break;
            }
        }

        private void ShowHLRNotifications()
        {
            hlrManager.LoadDataFromStorage();
            IList<HolidayLeaveRequest> pendingHlrs = hlrManager.GetPendingRequests();
            int nrPendingRequests = pendingHlrs.Count;
            panelHLRNotifications.Visible = nrPendingRequests > 0;

            if (nrPendingRequests > 0)
            {
                lbHLRNotifications.Text = nrPendingRequests > 1 ? 
                    $"There are {nrPendingRequests} new holiday requests (click to manage)." 
                    : $"There is {nrPendingRequests} new holiday requests (click to manage).";
            }
        }

        private void lbHLRNotifications_Click(object sender, EventArgs e)
        {
            tabControlAdministration.SelectedTab = EmployeesTab;
            tabControlEmployees.SelectedTab = HolidayRequestsTab;
        }

        private void UpdateDGVHLR(IList<HolidayLeaveRequest> requests)
        {
            var HLRDataSource =
                requests.Select(x => new
                {
                    ID = x.Id,
                    Employee = departmentManagement.GetEmployeeById(x.EmployeeId) != null ? 
                    $"{departmentManagement.GetEmployeeById(x.EmployeeId).FirstName} " +
                    $"{departmentManagement.GetEmployeeById(x.EmployeeId).LastName}": "",
                    x.StartDate,
                    x.EndDate,
                    x.TotalDays,
                    x.Status,
                    Reason = x.Comments,
                    x.RequestDate
                }).ToList();

            dgvHLR.DataSource = HLRDataSource;
            dgvHLR.ClearSelection();
        }

        private void btnHolidayRequestsAccept_Click(object sender, EventArgs e)
        {
            if (dgvHLR.SelectedRows.Count == 1)
            {
                int requestId = Convert.ToInt32(dgvHLR.SelectedCells[0].Value);
                HolidayLeaveRequest currRequest = hlrManager.GetHLR(requestId);
                
                if (currRequest.Status != "InProgress")
                {
                    MessageBox.Show("This request is already processed!");
                }
                else
                {
                    hlrManager.AcceptHLR(currRequest, this.departmentManagement);
                    cbFilterHLR.SelectedIndex = 0; // All
                    UpdateDGVHLR(hlrManager.GetAllRequests());
                    MessageBox.Show("You have accepted this request!");
                }
            }
            else
            {
                MessageBox.Show("Please, select a request to mark it as /Accepted/");
            }
        }

        private void btnHolidayRequestsDecline_Click(object sender, EventArgs e)
        {
            if (dgvHLR.SelectedRows.Count == 1)
            {
                int requestId = Convert.ToInt32(dgvHLR.SelectedCells[0].Value);
                HolidayLeaveRequest currRequest = hlrManager.GetHLR(requestId);

                if (currRequest.Status != "InProgress")
                {
                    MessageBox.Show("This request is already processed!");
                }
                else
                {
                    hlrManager.DeclineHLR(currRequest, this.departmentManagement);
                    cbFilterHLR.SelectedIndex = 0; // All
                    UpdateDGVHLR(hlrManager.GetAllRequests());
                    MessageBox.Show("You have declined this request!");
                }
            }
            else
            {
                MessageBox.Show("Please, select a request to mark it as /Declined/");
            }
        }


        private void btnHolidayRequestsClearSelected_Click(object sender, EventArgs e)
        {
            if (dgvHLR.SelectedRows.Count == 1)
            {
                dgvHLR.ClearSelection();
            }
            else
            {
                MessageBox.Show("To unmark request, you should have selected one beforehand! ");
            }
        }

        private void ChangeSettingsButtonColor(CheckBox cb)
        {
            if (cb.Checked == true)
            {

                cb.BackColor = Color.FromArgb(82, 255, 163);
            }
            else
            {
                cb.BackColor = Color.FromArgb(250, 69, 60);
            }
        }

        private void manageEmpCH_CheckedChanged(object sender, EventArgs e)
        {
            //ChangeSettingsButtonColor(manageEmpCH);  
        }

        private void weeklyScheduleCH_CheckedChanged(object sender, EventArgs e)
        {
            //ChangeSettingsButtonColor(weeklyScheduleCH);
        }

        private void holidayLeaveReqCH_CheckedChanged(object sender, EventArgs e)
        {
            //ChangeSettingsButtonColor(holidayLeaveReqCH);
        }

        private void manageAttendanceCH_CheckedChanged(object sender, EventArgs e)
        {
            //ChangeSettingsButtonColor(manageAttendanceCH);
        }

        private void manageStockCH_CheckedChanged(object sender, EventArgs e)
        {
            //ChangeSettingsButtonColor(manageStockCH);
        }

        private void manageDepCH_CheckedChanged(object sender, EventArgs e)
        {
            //ChangeSettingsButtonColor(manageDepCH);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RefreshWeeklySchedule();
        }

        private void btnRemShift_Click(object sender, EventArgs e)
        {

            int shiftID = 0;

            if (dgvSchedule.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSchedule.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSchedule.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["colID"].Value);

                shiftID = Convert.ToInt32(id);
            }

            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                foreach (Shift s in emp.GetAllShifts())
                {
                    if (shiftID == s.ID)
                    {
                        dbc.RemoveShift(s);
                    }
                }
            }
        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {

        }

        private void cbEmps_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Employee with Id: (id)
            Employee emp = (Employee)cbEmps.SelectedItem;

            if (emp != null)
            {
                lbEmpInfo.Text = $"Selected {emp.FirstName} {emp.LastName} ({emp.Id})";
            }
               
        }

        private void btnGoBackManual_Click(object sender, EventArgs e)
        {
            gbAssignShiftManually.Visible = false;
            btnAutoShifts.Visible = true;
            btnManShifts.Visible = true;
        }

        private void btnManShifts_Click(object sender, EventArgs e)
        {
            gbAssignShiftManually.Visible = true;
            btnAutoShifts.Visible = false;
            btnManShifts.Visible = false;

        }

        private void btnAutoShifts_Click(object sender, EventArgs e)
        {
            gbAutoSch.Visible = true;
            btnAutoShifts.Visible = false;
            btnManShifts.Visible = false;
        }

        private void btnGoBackAuto_Click(object sender, EventArgs e)
        {
            gbAutoSch.Visible = false;
            btnAutoShifts.Visible = true;
            btnManShifts.Visible = true;
        }

        private void btnGenAS_Click(object sender, EventArgs e)
        {
            int week = Convert.ToInt32(cbWeekAS.SelectedItem);

            if (week > 0 && week < 53)
            {
                foreach (Employee emp in departmentManagement.GetAllEmployees())
                {
                    foreach (Shift s in emp.GetAllShifts())
                    {
                        if (GetIso8601WeekOfYear(s.Date) == week)
                        {
                            dbc.RemoveShift(s);
                        }
                    }
                }

                MessageBox.Show($"You have generate a new schedule for week {week}.");

                cbWeekAS.SelectedIndex = -1;

                ash.AssignShifts(week, 2021, currentEmp.Id);

                dbc.GetShifts(departmentManagement);
                //RefreshWeeklySchedule();
            }
        }

        private void cbFilterWFH_CheckedChanged(object sender, EventArgs e)
        {
            int week;

            if (cbWeekNumber.SelectedIndex != -1)
            {
                week = (int)cbWeekNumber.SelectedItem;
            }
            else
            {
                week = GetIso8601WeekOfYear(DateTime.Now);
            }


            RefreshWeeklyScheduleDGV(week);
        }

        private void cbFilterAttended_CheckedChanged(object sender, EventArgs e)
        {
            int week;

            if (cbWeekNumber.SelectedIndex != -1)
            {
                week = (int)cbWeekNumber.SelectedItem;
            }
            else
            {
                week = GetIso8601WeekOfYear(DateTime.Now);
            }


            RefreshWeeklyScheduleDGV(week);
        }
    }
}






