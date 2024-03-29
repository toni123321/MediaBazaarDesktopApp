﻿
namespace MediaBazaarApp
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ManageDepartmentsTab = new System.Windows.Forms.TabPage();
            this.btnShowAllDep = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.gbxSearchDep = new System.Windows.Forms.GroupBox();
            this.tbxSearchDep = new System.Windows.Forms.TextBox();
            this.gbxEditDepartment = new System.Windows.Forms.GroupBox();
            this.lbDepartmentCurrManagerEdit = new System.Windows.Forms.Label();
            this.lbDepartmentEditInfo = new System.Windows.Forms.Label();
            this.btnApplyChangesDepartment = new System.Windows.Forms.Button();
            this.cbDepartmentManagerEdit = new System.Windows.Forms.ComboBox();
            this.lbDepartmentManagerEdit = new System.Windows.Forms.Label();
            this.tbxDepartmentNameEdit = new System.Windows.Forms.TextBox();
            this.lbDepartmentNameEdit = new System.Windows.Forms.Label();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDepartmentsClearSelected = new System.Windows.Forms.Button();
            this.gbxCreateDeparmtent = new System.Windows.Forms.GroupBox();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.cbDepartmentManager = new System.Windows.Forms.ComboBox();
            this.lbDepartmentManager = new System.Windows.Forms.Label();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lbDepartmentName = new System.Windows.Forms.Label();
            this.StocksTab = new System.Windows.Forms.TabPage();
            this.tabControlStocks = new System.Windows.Forms.TabControl();
            this.AddStocksTab = new System.Windows.Forms.TabPage();
            this.kgLb = new System.Windows.Forms.Label();
            this.cmLb3 = new System.Windows.Forms.Label();
            this.lbStocksMainDetails = new System.Windows.Forms.Label();
            this.cmLb2 = new System.Windows.Forms.Label();
            this.lbStockShortDescription = new System.Windows.Forms.Label();
            this.cmLb1 = new System.Windows.Forms.Label();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.tbxStockWeight = new System.Windows.Forms.TextBox();
            this.tbxStockWidth = new System.Windows.Forms.TextBox();
            this.stockWeightLb = new System.Windows.Forms.Label();
            this.tbxStockQuantity = new System.Windows.Forms.TextBox();
            this.lbStockDimensions = new System.Windows.Forms.Label();
            this.tbxStockDepth = new System.Windows.Forms.TextBox();
            this.lbStockWidth = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lbStockHeight = new System.Windows.Forms.Label();
            this.tbxStockPrice = new System.Windows.Forms.TextBox();
            this.lbStockBrand = new System.Windows.Forms.Label();
            this.tbxStockShortDescription = new System.Windows.Forms.TextBox();
            this.tbxStockBrand = new System.Windows.Forms.TextBox();
            this.lbStockPrice = new System.Windows.Forms.Label();
            this.tbxStockHeight = new System.Windows.Forms.TextBox();
            this.lbStockDepth = new System.Windows.Forms.Label();
            this.lbStockModel = new System.Windows.Forms.Label();
            this.tbxStockModel = new System.Windows.Forms.TextBox();
            this.ManageStocksTab = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnShowAllStocks = new System.Windows.Forms.Button();
            this.gbxSearchStock = new System.Windows.Forms.GroupBox();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnStocksClearSelected = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.SchedulingTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWeeklySchedule = new System.Windows.Forms.TabPage();
            this.cbFilterAttended = new System.Windows.Forms.CheckBox();
            this.cbFilterWFH = new System.Windows.Forms.CheckBox();
            this.btnRemShift = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWFH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAssignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbWeekNumber = new System.Windows.Forms.Label();
            this.cbWeekNumber = new System.Windows.Forms.ComboBox();
            this.tpCreateSchedule = new System.Windows.Forms.TabPage();
            this.gbAutoSch = new System.Windows.Forms.GroupBox();
            this.lbWeekNrAS = new System.Windows.Forms.Label();
            this.btnGenAS = new System.Windows.Forms.Button();
            this.cbWeekAS = new System.Windows.Forms.ComboBox();
            this.btnGoBackAuto = new System.Windows.Forms.Button();
            this.lbASHinfo = new System.Windows.Forms.Label();
            this.gbAssignShiftManually = new System.Windows.Forms.GroupBox();
            this.btnGoBackManual = new System.Windows.Forms.Button();
            this.lbEmp = new System.Windows.Forms.Label();
            this.cbWFH = new System.Windows.Forms.CheckBox();
            this.lbDep = new System.Windows.Forms.Label();
            this.lbEmpInfo = new System.Windows.Forms.Label();
            this.lbWFH = new System.Windows.Forms.Label();
            this.cbEmps = new System.Windows.Forms.ComboBox();
            this.cbDeps = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lbShiftType = new System.Windows.Forms.Label();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.lbShiftDate = new System.Windows.Forms.Label();
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.btnManShifts = new System.Windows.Forms.Button();
            this.btnAutoShifts = new System.Windows.Forms.Button();
            this.tpManageAttendance = new System.Windows.Forms.TabPage();
            this.btnApplyAttendanceChanges = new System.Windows.Forms.Button();
            this.tbReasonForAbsence = new System.Windows.Forms.TextBox();
            this.cbHasAttended = new System.Windows.Forms.CheckBox();
            this.lbReason = new System.Windows.Forms.Label();
            this.lbHasAttended = new System.Windows.Forms.Label();
            this.lbShift = new System.Windows.Forms.Label();
            this.cbEmployeesShifts = new System.Windows.Forms.ComboBox();
            this.lbSelectedEmp = new System.Windows.Forms.Label();
            this.lbSelectedDep = new System.Windows.Forms.Label();
            this.cbSelectedEmp = new System.Windows.Forms.ComboBox();
            this.cbAllDeps = new System.Windows.Forms.ComboBox();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.tabControlEmployees = new System.Windows.Forms.TabControl();
            this.AddEmpTab = new System.Windows.Forms.TabPage();
            this.cbxEmpIndefiniteContract = new System.Windows.Forms.CheckBox();
            this.dtpEmpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmpEndDate = new System.Windows.Forms.Label();
            this.dtpEmpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmpStartDate = new System.Windows.Forms.Label();
            this.lbEmpNationality = new System.Windows.Forms.Label();
            this.tbxEmpNationality = new System.Windows.Forms.TextBox();
            this.cbEmConRelation = new System.Windows.Forms.ComboBox();
            this.lbEmConRelation = new System.Windows.Forms.Label();
            this.tbxEmConName = new System.Windows.Forms.TextBox();
            this.lbEmConName = new System.Windows.Forms.Label();
            this.tbxEmConEmail = new System.Windows.Forms.TextBox();
            this.lbEmConEmail = new System.Windows.Forms.Label();
            this.tbxEmConPhone = new System.Windows.Forms.TextBox();
            this.lbEmConPhone = new System.Windows.Forms.Label();
            this.lbEmpEmConDetails = new System.Windows.Forms.Label();
            this.lbEmpBsn = new System.Windows.Forms.Label();
            this.tbxEmpBsn = new System.Windows.Forms.TextBox();
            this.nudEmpHourlyWages = new System.Windows.Forms.NumericUpDown();
            this.cbEmpDepartment = new System.Windows.Forms.ComboBox();
            this.lbEmpDepartment = new System.Windows.Forms.Label();
            this.cbEmpEmploymentType = new System.Windows.Forms.ComboBox();
            this.lbEmpJobSpec = new System.Windows.Forms.Label();
            this.lbEmpAddressStreet = new System.Windows.Forms.Label();
            this.lbEmpPersonalInfo = new System.Windows.Forms.Label();
            this.tbxEmpAddressStreet = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCity = new System.Windows.Forms.TextBox();
            this.cbEmpGender = new System.Windows.Forms.ComboBox();
            this.lbEmpAddressCity = new System.Windows.Forms.Label();
            this.tbxEmpEmail = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCountry = new System.Windows.Forms.TextBox();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.lbEmpAddressPostCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpAddressCountry = new System.Windows.Forms.Label();
            this.dtpEmpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxEmpAddressPostCode = new System.Windows.Forms.TextBox();
            this.btnAddEmpoyee = new System.Windows.Forms.Button();
            this.lbEmpEmployementType = new System.Windows.Forms.Label();
            this.lbEmpDateOfBirth = new System.Windows.Forms.Label();
            this.lbEmpHourlyWages = new System.Windows.Forms.Label();
            this.tbxEmpPhone = new System.Windows.Forms.TextBox();
            this.lbEmpPhone = new System.Windows.Forms.Label();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.tbxEmpLname = new System.Windows.Forms.TextBox();
            this.lbEmpLname = new System.Windows.Forms.Label();
            this.tbxEmpFname = new System.Windows.Forms.TextBox();
            this.lbEmpFname = new System.Windows.Forms.Label();
            this.ManageEmpTab = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.gbxShowEmp = new System.Windows.Forms.GroupBox();
            this.cbSelectEmpDepartment = new System.Windows.Forms.ComboBox();
            this.gbxSearchEmp = new System.Windows.Forms.GroupBox();
            this.tbxSearchEmp = new System.Windows.Forms.TextBox();
            this.btnClearSelectedEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.EmpExpiredContractTab = new System.Windows.Forms.TabPage();
            this.gbxEmpRenewContract = new System.Windows.Forms.GroupBox();
            this.lbEmpIdRenewContract = new System.Windows.Forms.Label();
            this.lbNamesEmpRenewContract = new System.Windows.Forms.Label();
            this.btnEmpSubmitChangesNewContract = new System.Windows.Forms.Button();
            this.cbxEmpMakeNewContractIndefinite = new System.Windows.Forms.CheckBox();
            this.dtpEndDateNewContract = new System.Windows.Forms.DateTimePicker();
            this.lbEmpEndDateNewContract = new System.Windows.Forms.Label();
            this.dtpEmpStartDateNewContract = new System.Windows.Forms.DateTimePicker();
            this.lbEmpStartDateNewContract = new System.Windows.Forms.Label();
            this.btnEmpExpiredContractUnmarkSelected = new System.Windows.Forms.Button();
            this.btnEmpRenewContract = new System.Windows.Forms.Button();
            this.dgvEmployeesExpiredContract = new System.Windows.Forms.DataGridView();
            this.HolidayRequestsTab = new System.Windows.Forms.TabPage();
            this.lblHLRstatus = new System.Windows.Forms.Label();
            this.lbHLR = new System.Windows.Forms.Label();
            this.cbFilterHLR = new System.Windows.Forms.ComboBox();
            this.dgvHLR = new System.Windows.Forms.DataGridView();
            this.btnHolidayRequestsClearSelected = new System.Windows.Forms.Button();
            this.btnHolidayRequestsDecline = new System.Windows.Forms.Button();
            this.btnHolidayRequestsAccept = new System.Windows.Forms.Button();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.panelEmpExpiredContract = new System.Windows.Forms.Panel();
            this.lbEmpExpiredContract = new System.Windows.Forms.Label();
            this.pbxEmpExpiredContract = new System.Windows.Forms.PictureBox();
            this.panelHLRNotifications = new System.Windows.Forms.Panel();
            this.lbHLRNotifications = new System.Windows.Forms.Label();
            this.pbxHLRNotifications = new System.Windows.Forms.PictureBox();
            this.manageDepartmentsShortcut = new System.Windows.Forms.Panel();
            this.manageDepLBL = new System.Windows.Forms.Label();
            this.manageDepPic = new System.Windows.Forms.PictureBox();
            this.manageStockShortcut = new System.Windows.Forms.Panel();
            this.manageStockLBL = new System.Windows.Forms.Label();
            this.manageStockPic = new System.Windows.Forms.PictureBox();
            this.manageAttendanceShortcut = new System.Windows.Forms.Panel();
            this.manageAttendanceLBL = new System.Windows.Forms.Label();
            this.manageAttendancePic = new System.Windows.Forms.PictureBox();
            this.weeklySchedukeShortcut = new System.Windows.Forms.Panel();
            this.weeklyScheduleLBL = new System.Windows.Forms.Label();
            this.weekSchedulePic = new System.Windows.Forms.PictureBox();
            this.holidayLeaveRequestsShortcut = new System.Windows.Forms.Panel();
            this.holidayLeaveLBL = new System.Windows.Forms.Label();
            this.holidayLeavePic = new System.Windows.Forms.PictureBox();
            this.manageEmpShortcut = new System.Windows.Forms.Panel();
            this.manageEmpLBL = new System.Windows.Forms.Label();
            this.manageEmpPic = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.tabControlAdministration = new System.Windows.Forms.TabControl();
            this.tabPageEditAccountRequests = new System.Windows.Forms.TabPage();
            this.btnUnmarkSelectedEditAccountRequest = new System.Windows.Forms.Button();
            this.lbFilterEditAccountRequests = new System.Windows.Forms.Label();
            this.cbFilterEditAccountRequests = new System.Windows.Forms.ComboBox();
            this.lbTitleEditAccountRequests = new System.Windows.Forms.Label();
            this.btnDeclineEditAccountRequest = new System.Windows.Forms.Button();
            this.btnAcceptEditAccountRequest = new System.Windows.Forms.Button();
            this.dgvEditAccountRequests = new System.Windows.Forms.DataGridView();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.applyShortcutsBTN = new System.Windows.Forms.Button();
            this.manageAttendanceCH = new System.Windows.Forms.CheckBox();
            this.manageStockCH = new System.Windows.Forms.CheckBox();
            this.manageDepCH = new System.Windows.Forms.CheckBox();
            this.weeklyScheduleCH = new System.Windows.Forms.CheckBox();
            this.holidayLeaveReqCH = new System.Windows.Forms.CheckBox();
            this.manageEmpCH = new System.Windows.Forms.CheckBox();
            this.lbHLRDays = new System.Windows.Forms.Label();
            this.tbxHLRDays = new System.Windows.Forms.TextBox();
            this.ManageDepartmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.gbxSearchDep.SuspendLayout();
            this.gbxEditDepartment.SuspendLayout();
            this.gbxCreateDeparmtent.SuspendLayout();
            this.StocksTab.SuspendLayout();
            this.tabControlStocks.SuspendLayout();
            this.AddStocksTab.SuspendLayout();
            this.ManageStocksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.gbxSearchStock.SuspendLayout();
            this.SchedulingTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbWeeklySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.tpCreateSchedule.SuspendLayout();
            this.gbAutoSch.SuspendLayout();
            this.gbAssignShiftManually.SuspendLayout();
            this.tpManageAttendance.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            this.tabControlEmployees.SuspendLayout();
            this.AddEmpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpHourlyWages)).BeginInit();
            this.ManageEmpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbxShowEmp.SuspendLayout();
            this.gbxSearchEmp.SuspendLayout();
            this.EmpExpiredContractTab.SuspendLayout();
            this.gbxEmpRenewContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesExpiredContract)).BeginInit();
            this.HolidayRequestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHLR)).BeginInit();
            this.HomeTab.SuspendLayout();
            this.panelEmpExpiredContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmpExpiredContract)).BeginInit();
            this.panelHLRNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHLRNotifications)).BeginInit();
            this.manageDepartmentsShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDepPic)).BeginInit();
            this.manageStockShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageStockPic)).BeginInit();
            this.manageAttendanceShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageAttendancePic)).BeginInit();
            this.weeklySchedukeShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekSchedulePic)).BeginInit();
            this.holidayLeaveRequestsShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidayLeavePic)).BeginInit();
            this.manageEmpShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmpPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabControlAdministration.SuspendLayout();
            this.tabPageEditAccountRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAccountRequests)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageDepartmentsTab
            // 
            this.ManageDepartmentsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ManageDepartmentsTab.Controls.Add(this.btnShowAllDep);
            this.ManageDepartmentsTab.Controls.Add(this.dgvDepartments);
            this.ManageDepartmentsTab.Controls.Add(this.gbxSearchDep);
            this.ManageDepartmentsTab.Controls.Add(this.gbxEditDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnRemoveDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnEditDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnDepartmentsClearSelected);
            this.ManageDepartmentsTab.Controls.Add(this.gbxCreateDeparmtent);
            this.ManageDepartmentsTab.Location = new System.Drawing.Point(4, 29);
            this.ManageDepartmentsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageDepartmentsTab.Name = "ManageDepartmentsTab";
            this.ManageDepartmentsTab.Size = new System.Drawing.Size(1097, 699);
            this.ManageDepartmentsTab.TabIndex = 6;
            this.ManageDepartmentsTab.Text = "Departments";
            // 
            // btnShowAllDep
            // 
            this.btnShowAllDep.BackColor = System.Drawing.Color.LightSalmon;
            this.btnShowAllDep.Location = new System.Drawing.Point(391, 56);
            this.btnShowAllDep.Name = "btnShowAllDep";
            this.btnShowAllDep.Size = new System.Drawing.Size(167, 77);
            this.btnShowAllDep.TabIndex = 8;
            this.btnShowAllDep.Text = "Show all";
            this.btnShowAllDep.UseVisualStyleBackColor = false;
            this.btnShowAllDep.Click += new System.EventHandler(this.btnShowAllDep_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(15, 166);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(591, 438);
            this.dgvDepartments.TabIndex = 25;
            // 
            // gbxSearchDep
            // 
            this.gbxSearchDep.BackColor = System.Drawing.Color.Transparent;
            this.gbxSearchDep.Controls.Add(this.tbxSearchDep);
            this.gbxSearchDep.Location = new System.Drawing.Point(22, 28);
            this.gbxSearchDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchDep.Name = "gbxSearchDep";
            this.gbxSearchDep.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchDep.Size = new System.Drawing.Size(363, 113);
            this.gbxSearchDep.TabIndex = 18;
            this.gbxSearchDep.TabStop = false;
            this.gbxSearchDep.Text = "Search for specific department";
            // 
            // tbxSearchDep
            // 
            this.tbxSearchDep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchDep.Location = new System.Drawing.Point(24, 53);
            this.tbxSearchDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchDep.Name = "tbxSearchDep";
            this.tbxSearchDep.Size = new System.Drawing.Size(209, 27);
            this.tbxSearchDep.TabIndex = 7;
            this.tbxSearchDep.Click += new System.EventHandler(this.tbxSearchDep_Click);
            this.tbxSearchDep.TextChanged += new System.EventHandler(this.tbxSearchDep_TextChanged);
            // 
            // gbxEditDepartment
            // 
            this.gbxEditDepartment.BackColor = System.Drawing.Color.Transparent;
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentCurrManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentEditInfo);
            this.gbxEditDepartment.Controls.Add(this.btnApplyChangesDepartment);
            this.gbxEditDepartment.Controls.Add(this.cbDepartmentManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.tbxDepartmentNameEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentNameEdit);
            this.gbxEditDepartment.Location = new System.Drawing.Point(622, 353);
            this.gbxEditDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditDepartment.Name = "gbxEditDepartment";
            this.gbxEditDepartment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditDepartment.Size = new System.Drawing.Size(457, 350);
            this.gbxEditDepartment.TabIndex = 11;
            this.gbxEditDepartment.TabStop = false;
            this.gbxEditDepartment.Text = "Edit department";
            // 
            // lbDepartmentCurrManagerEdit
            // 
            this.lbDepartmentCurrManagerEdit.AutoSize = true;
            this.lbDepartmentCurrManagerEdit.Location = new System.Drawing.Point(103, 52);
            this.lbDepartmentCurrManagerEdit.Name = "lbDepartmentCurrManagerEdit";
            this.lbDepartmentCurrManagerEdit.Size = new System.Drawing.Size(123, 20);
            this.lbDepartmentCurrManagerEdit.TabIndex = 6;
            this.lbDepartmentCurrManagerEdit.Text = "Current manager:";
            // 
            // lbDepartmentEditInfo
            // 
            this.lbDepartmentEditInfo.AutoSize = true;
            this.lbDepartmentEditInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbDepartmentEditInfo.Location = new System.Drawing.Point(102, 24);
            this.lbDepartmentEditInfo.Name = "lbDepartmentEditInfo";
            this.lbDepartmentEditInfo.Size = new System.Drawing.Size(227, 28);
            this.lbDepartmentEditInfo.TabIndex = 5;
            this.lbDepartmentEditInfo.Text = "Department with Id:(id)";
            // 
            // btnApplyChangesDepartment
            // 
            this.btnApplyChangesDepartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnApplyChangesDepartment.Location = new System.Drawing.Point(107, 249);
            this.btnApplyChangesDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApplyChangesDepartment.Name = "btnApplyChangesDepartment";
            this.btnApplyChangesDepartment.Size = new System.Drawing.Size(205, 54);
            this.btnApplyChangesDepartment.TabIndex = 4;
            this.btnApplyChangesDepartment.Text = "Apply changes";
            this.btnApplyChangesDepartment.UseVisualStyleBackColor = false;
            this.btnApplyChangesDepartment.Click += new System.EventHandler(this.btnApplyChangesDepartment_Click);
            // 
            // cbDepartmentManagerEdit
            // 
            this.cbDepartmentManagerEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartmentManagerEdit.FormattingEnabled = true;
            this.cbDepartmentManagerEdit.Location = new System.Drawing.Point(107, 199);
            this.cbDepartmentManagerEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDepartmentManagerEdit.Name = "cbDepartmentManagerEdit";
            this.cbDepartmentManagerEdit.Size = new System.Drawing.Size(204, 28);
            this.cbDepartmentManagerEdit.TabIndex = 1;
            this.cbDepartmentManagerEdit.Text = "Choose a manager";
            // 
            // lbDepartmentManagerEdit
            // 
            this.lbDepartmentManagerEdit.AutoSize = true;
            this.lbDepartmentManagerEdit.Location = new System.Drawing.Point(103, 162);
            this.lbDepartmentManagerEdit.Name = "lbDepartmentManagerEdit";
            this.lbDepartmentManagerEdit.Size = new System.Drawing.Size(155, 20);
            this.lbDepartmentManagerEdit.TabIndex = 3;
            this.lbDepartmentManagerEdit.Text = "Department manager:";
            // 
            // tbxDepartmentNameEdit
            // 
            this.tbxDepartmentNameEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxDepartmentNameEdit.Location = new System.Drawing.Point(107, 120);
            this.tbxDepartmentNameEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDepartmentNameEdit.Name = "tbxDepartmentNameEdit";
            this.tbxDepartmentNameEdit.Size = new System.Drawing.Size(204, 27);
            this.tbxDepartmentNameEdit.TabIndex = 1;
            // 
            // lbDepartmentNameEdit
            // 
            this.lbDepartmentNameEdit.AutoSize = true;
            this.lbDepartmentNameEdit.Location = new System.Drawing.Point(103, 96);
            this.lbDepartmentNameEdit.Name = "lbDepartmentNameEdit";
            this.lbDepartmentNameEdit.Size = new System.Drawing.Size(52, 20);
            this.lbDepartmentNameEdit.TabIndex = 1;
            this.lbDepartmentNameEdit.Text = "Name:";
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveDepartment.Location = new System.Drawing.Point(465, 632);
            this.btnRemoveDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(130, 54);
            this.btnRemoveDepartment.TabIndex = 12;
            this.btnRemoveDepartment.Text = "Remove";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditDepartment.Location = new System.Drawing.Point(329, 632);
            this.btnEditDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(130, 54);
            this.btnEditDepartment.TabIndex = 10;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDepartmentsClearSelected
            // 
            this.btnDepartmentsClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDepartmentsClearSelected.Location = new System.Drawing.Point(22, 632);
            this.btnDepartmentsClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartmentsClearSelected.Name = "btnDepartmentsClearSelected";
            this.btnDepartmentsClearSelected.Size = new System.Drawing.Size(171, 54);
            this.btnDepartmentsClearSelected.TabIndex = 9;
            this.btnDepartmentsClearSelected.Text = "Unmark selected";
            this.btnDepartmentsClearSelected.UseVisualStyleBackColor = false;
            this.btnDepartmentsClearSelected.Click += new System.EventHandler(this.btnDepartmentsClearSelected_Click);
            // 
            // gbxCreateDeparmtent
            // 
            this.gbxCreateDeparmtent.BackColor = System.Drawing.Color.Transparent;
            this.gbxCreateDeparmtent.Controls.Add(this.btnCreateDepartment);
            this.gbxCreateDeparmtent.Controls.Add(this.cbDepartmentManager);
            this.gbxCreateDeparmtent.Controls.Add(this.lbDepartmentManager);
            this.gbxCreateDeparmtent.Controls.Add(this.tbxDepartmentName);
            this.gbxCreateDeparmtent.Controls.Add(this.lbDepartmentName);
            this.gbxCreateDeparmtent.Location = new System.Drawing.Point(622, 28);
            this.gbxCreateDeparmtent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCreateDeparmtent.Name = "gbxCreateDeparmtent";
            this.gbxCreateDeparmtent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCreateDeparmtent.Size = new System.Drawing.Size(457, 306);
            this.gbxCreateDeparmtent.TabIndex = 6;
            this.gbxCreateDeparmtent.TabStop = false;
            this.gbxCreateDeparmtent.Text = "Create new department";
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCreateDepartment.Location = new System.Drawing.Point(137, 193);
            this.btnCreateDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(205, 54);
            this.btnCreateDepartment.TabIndex = 4;
            this.btnCreateDepartment.Text = "Create new department";
            this.btnCreateDepartment.UseVisualStyleBackColor = false;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // cbDepartmentManager
            // 
            this.cbDepartmentManager.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartmentManager.FormattingEnabled = true;
            this.cbDepartmentManager.Location = new System.Drawing.Point(137, 141);
            this.cbDepartmentManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDepartmentManager.Name = "cbDepartmentManager";
            this.cbDepartmentManager.Size = new System.Drawing.Size(204, 28);
            this.cbDepartmentManager.TabIndex = 1;
            this.cbDepartmentManager.Text = "Choose a manager";
            // 
            // lbDepartmentManager
            // 
            this.lbDepartmentManager.AutoSize = true;
            this.lbDepartmentManager.Location = new System.Drawing.Point(133, 117);
            this.lbDepartmentManager.Name = "lbDepartmentManager";
            this.lbDepartmentManager.Size = new System.Drawing.Size(155, 20);
            this.lbDepartmentManager.TabIndex = 3;
            this.lbDepartmentManager.Text = "Department manager:";
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxDepartmentName.Location = new System.Drawing.Point(137, 75);
            this.tbxDepartmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(204, 27);
            this.tbxDepartmentName.TabIndex = 1;
            // 
            // lbDepartmentName
            // 
            this.lbDepartmentName.AutoSize = true;
            this.lbDepartmentName.Location = new System.Drawing.Point(135, 51);
            this.lbDepartmentName.Name = "lbDepartmentName";
            this.lbDepartmentName.Size = new System.Drawing.Size(52, 20);
            this.lbDepartmentName.TabIndex = 1;
            this.lbDepartmentName.Text = "Name:";
            // 
            // StocksTab
            // 
            this.StocksTab.Controls.Add(this.tabControlStocks);
            this.StocksTab.Location = new System.Drawing.Point(4, 29);
            this.StocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StocksTab.Name = "StocksTab";
            this.StocksTab.Size = new System.Drawing.Size(1097, 699);
            this.StocksTab.TabIndex = 2;
            this.StocksTab.Text = "Stocks";
            this.StocksTab.UseVisualStyleBackColor = true;
            // 
            // tabControlStocks
            // 
            this.tabControlStocks.Controls.Add(this.AddStocksTab);
            this.tabControlStocks.Controls.Add(this.ManageStocksTab);
            this.tabControlStocks.Location = new System.Drawing.Point(4, 4);
            this.tabControlStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlStocks.Name = "tabControlStocks";
            this.tabControlStocks.SelectedIndex = 0;
            this.tabControlStocks.Size = new System.Drawing.Size(1090, 771);
            this.tabControlStocks.TabIndex = 1;
            // 
            // AddStocksTab
            // 
            this.AddStocksTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddStocksTab.Controls.Add(this.kgLb);
            this.AddStocksTab.Controls.Add(this.cmLb3);
            this.AddStocksTab.Controls.Add(this.lbStocksMainDetails);
            this.AddStocksTab.Controls.Add(this.cmLb2);
            this.AddStocksTab.Controls.Add(this.lbStockShortDescription);
            this.AddStocksTab.Controls.Add(this.cmLb1);
            this.AddStocksTab.Controls.Add(this.lbStockQuantity);
            this.AddStocksTab.Controls.Add(this.tbxStockWeight);
            this.AddStocksTab.Controls.Add(this.tbxStockWidth);
            this.AddStocksTab.Controls.Add(this.stockWeightLb);
            this.AddStocksTab.Controls.Add(this.tbxStockQuantity);
            this.AddStocksTab.Controls.Add(this.lbStockDimensions);
            this.AddStocksTab.Controls.Add(this.tbxStockDepth);
            this.AddStocksTab.Controls.Add(this.lbStockWidth);
            this.AddStocksTab.Controls.Add(this.btnAddStock);
            this.AddStocksTab.Controls.Add(this.lbStockHeight);
            this.AddStocksTab.Controls.Add(this.tbxStockPrice);
            this.AddStocksTab.Controls.Add(this.lbStockBrand);
            this.AddStocksTab.Controls.Add(this.tbxStockShortDescription);
            this.AddStocksTab.Controls.Add(this.tbxStockBrand);
            this.AddStocksTab.Controls.Add(this.lbStockPrice);
            this.AddStocksTab.Controls.Add(this.tbxStockHeight);
            this.AddStocksTab.Controls.Add(this.lbStockDepth);
            this.AddStocksTab.Controls.Add(this.lbStockModel);
            this.AddStocksTab.Controls.Add(this.tbxStockModel);
            this.AddStocksTab.Location = new System.Drawing.Point(4, 29);
            this.AddStocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddStocksTab.Name = "AddStocksTab";
            this.AddStocksTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddStocksTab.Size = new System.Drawing.Size(1082, 738);
            this.AddStocksTab.TabIndex = 0;
            this.AddStocksTab.Text = "Add stocks";
            // 
            // kgLb
            // 
            this.kgLb.AutoSize = true;
            this.kgLb.Location = new System.Drawing.Point(769, 317);
            this.kgLb.Name = "kgLb";
            this.kgLb.Size = new System.Drawing.Size(28, 20);
            this.kgLb.TabIndex = 26;
            this.kgLb.Text = "kg.";
            // 
            // cmLb3
            // 
            this.cmLb3.AutoSize = true;
            this.cmLb3.Location = new System.Drawing.Point(769, 249);
            this.cmLb3.Name = "cmLb3";
            this.cmLb3.Size = new System.Drawing.Size(32, 20);
            this.cmLb3.TabIndex = 25;
            this.cmLb3.Text = "cm.";
            // 
            // lbStocksMainDetails
            // 
            this.lbStocksMainDetails.AutoSize = true;
            this.lbStocksMainDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbStocksMainDetails.Location = new System.Drawing.Point(280, 51);
            this.lbStocksMainDetails.Name = "lbStocksMainDetails";
            this.lbStocksMainDetails.Size = new System.Drawing.Size(122, 28);
            this.lbStocksMainDetails.TabIndex = 21;
            this.lbStocksMainDetails.Text = "Main details";
            // 
            // cmLb2
            // 
            this.cmLb2.AutoSize = true;
            this.cmLb2.Location = new System.Drawing.Point(769, 189);
            this.cmLb2.Name = "cmLb2";
            this.cmLb2.Size = new System.Drawing.Size(32, 20);
            this.cmLb2.TabIndex = 24;
            this.cmLb2.Text = "cm.";
            // 
            // lbStockShortDescription
            // 
            this.lbStockShortDescription.AutoSize = true;
            this.lbStockShortDescription.Location = new System.Drawing.Point(280, 372);
            this.lbStockShortDescription.Name = "lbStockShortDescription";
            this.lbStockShortDescription.Size = new System.Drawing.Size(125, 20);
            this.lbStockShortDescription.TabIndex = 8;
            this.lbStockShortDescription.Text = "Short description:";
            // 
            // cmLb1
            // 
            this.cmLb1.AutoSize = true;
            this.cmLb1.Location = new System.Drawing.Point(769, 130);
            this.cmLb1.Name = "cmLb1";
            this.cmLb1.Size = new System.Drawing.Size(32, 20);
            this.cmLb1.TabIndex = 23;
            this.cmLb1.Text = "cm.";
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(280, 283);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(68, 20);
            this.lbStockQuantity.TabIndex = 12;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // tbxStockWeight
            // 
            this.tbxStockWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockWeight.Location = new System.Drawing.Point(610, 310);
            this.tbxStockWeight.Name = "tbxStockWeight";
            this.tbxStockWeight.Size = new System.Drawing.Size(154, 27);
            this.tbxStockWeight.TabIndex = 22;
            // 
            // tbxStockWidth
            // 
            this.tbxStockWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockWidth.Location = new System.Drawing.Point(610, 127);
            this.tbxStockWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockWidth.Name = "tbxStockWidth";
            this.tbxStockWidth.Size = new System.Drawing.Size(154, 27);
            this.tbxStockWidth.TabIndex = 16;
            // 
            // stockWeightLb
            // 
            this.stockWeightLb.AutoSize = true;
            this.stockWeightLb.Location = new System.Drawing.Point(606, 287);
            this.stockWeightLb.Name = "stockWeightLb";
            this.stockWeightLb.Size = new System.Drawing.Size(59, 20);
            this.stockWeightLb.TabIndex = 2;
            this.stockWeightLb.Text = "Weight:";
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockQuantity.Location = new System.Drawing.Point(284, 307);
            this.tbxStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(154, 27);
            this.tbxStockQuantity.TabIndex = 13;
            // 
            // lbStockDimensions
            // 
            this.lbStockDimensions.AutoSize = true;
            this.lbStockDimensions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbStockDimensions.Location = new System.Drawing.Point(606, 51);
            this.lbStockDimensions.Name = "lbStockDimensions";
            this.lbStockDimensions.Size = new System.Drawing.Size(119, 28);
            this.lbStockDimensions.TabIndex = 6;
            this.lbStockDimensions.Text = "Dimensions";
            // 
            // tbxStockDepth
            // 
            this.tbxStockDepth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockDepth.Location = new System.Drawing.Point(610, 245);
            this.tbxStockDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockDepth.Name = "tbxStockDepth";
            this.tbxStockDepth.Size = new System.Drawing.Size(154, 27);
            this.tbxStockDepth.TabIndex = 20;
            // 
            // lbStockWidth
            // 
            this.lbStockWidth.AutoSize = true;
            this.lbStockWidth.Location = new System.Drawing.Point(606, 103);
            this.lbStockWidth.Name = "lbStockWidth";
            this.lbStockWidth.Size = new System.Drawing.Size(52, 20);
            this.lbStockWidth.TabIndex = 15;
            this.lbStockWidth.Text = "Width:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddStock.Location = new System.Drawing.Point(399, 513);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(259, 61);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Add new stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // lbStockHeight
            // 
            this.lbStockHeight.AutoSize = true;
            this.lbStockHeight.Location = new System.Drawing.Point(606, 158);
            this.lbStockHeight.Name = "lbStockHeight";
            this.lbStockHeight.Size = new System.Drawing.Size(57, 20);
            this.lbStockHeight.TabIndex = 17;
            this.lbStockHeight.Text = "Height:";
            // 
            // tbxStockPrice
            // 
            this.tbxStockPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockPrice.Location = new System.Drawing.Point(284, 252);
            this.tbxStockPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockPrice.Name = "tbxStockPrice";
            this.tbxStockPrice.Size = new System.Drawing.Size(154, 27);
            this.tbxStockPrice.TabIndex = 5;
            // 
            // lbStockBrand
            // 
            this.lbStockBrand.AutoSize = true;
            this.lbStockBrand.Location = new System.Drawing.Point(280, 109);
            this.lbStockBrand.Name = "lbStockBrand";
            this.lbStockBrand.Size = new System.Drawing.Size(51, 20);
            this.lbStockBrand.TabIndex = 0;
            this.lbStockBrand.Text = "Brand:";
            // 
            // tbxStockShortDescription
            // 
            this.tbxStockShortDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockShortDescription.Location = new System.Drawing.Point(284, 405);
            this.tbxStockShortDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockShortDescription.Multiline = true;
            this.tbxStockShortDescription.Name = "tbxStockShortDescription";
            this.tbxStockShortDescription.Size = new System.Drawing.Size(488, 74);
            this.tbxStockShortDescription.TabIndex = 9;
            // 
            // tbxStockBrand
            // 
            this.tbxStockBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockBrand.Location = new System.Drawing.Point(284, 133);
            this.tbxStockBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockBrand.Name = "tbxStockBrand";
            this.tbxStockBrand.Size = new System.Drawing.Size(230, 27);
            this.tbxStockBrand.TabIndex = 1;
            // 
            // lbStockPrice
            // 
            this.lbStockPrice.AutoSize = true;
            this.lbStockPrice.Location = new System.Drawing.Point(280, 228);
            this.lbStockPrice.Name = "lbStockPrice";
            this.lbStockPrice.Size = new System.Drawing.Size(44, 20);
            this.lbStockPrice.TabIndex = 4;
            this.lbStockPrice.Text = "Price:";
            // 
            // tbxStockHeight
            // 
            this.tbxStockHeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockHeight.Location = new System.Drawing.Point(610, 185);
            this.tbxStockHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockHeight.Name = "tbxStockHeight";
            this.tbxStockHeight.Size = new System.Drawing.Size(154, 27);
            this.tbxStockHeight.TabIndex = 18;
            // 
            // lbStockDepth
            // 
            this.lbStockDepth.AutoSize = true;
            this.lbStockDepth.Location = new System.Drawing.Point(606, 221);
            this.lbStockDepth.Name = "lbStockDepth";
            this.lbStockDepth.Size = new System.Drawing.Size(53, 20);
            this.lbStockDepth.TabIndex = 19;
            this.lbStockDepth.Text = "Depth:";
            // 
            // lbStockModel
            // 
            this.lbStockModel.AutoSize = true;
            this.lbStockModel.Location = new System.Drawing.Point(280, 164);
            this.lbStockModel.Name = "lbStockModel";
            this.lbStockModel.Size = new System.Drawing.Size(55, 20);
            this.lbStockModel.TabIndex = 2;
            this.lbStockModel.Text = "Model:";
            // 
            // tbxStockModel
            // 
            this.tbxStockModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockModel.Location = new System.Drawing.Point(284, 190);
            this.tbxStockModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockModel.Name = "tbxStockModel";
            this.tbxStockModel.Size = new System.Drawing.Size(230, 27);
            this.tbxStockModel.TabIndex = 3;
            // 
            // ManageStocksTab
            // 
            this.ManageStocksTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ManageStocksTab.Controls.Add(this.dgvStock);
            this.ManageStocksTab.Controls.Add(this.btnShowAllStocks);
            this.ManageStocksTab.Controls.Add(this.gbxSearchStock);
            this.ManageStocksTab.Controls.Add(this.btnStocksClearSelected);
            this.ManageStocksTab.Controls.Add(this.btnEditStock);
            this.ManageStocksTab.Controls.Add(this.btnRemoveStock);
            this.ManageStocksTab.Location = new System.Drawing.Point(4, 29);
            this.ManageStocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageStocksTab.Name = "ManageStocksTab";
            this.ManageStocksTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageStocksTab.Size = new System.Drawing.Size(1082, 738);
            this.ManageStocksTab.TabIndex = 1;
            this.ManageStocksTab.Text = "Manage stocks";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(10, 165);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1066, 366);
            this.dgvStock.TabIndex = 24;
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.BackColor = System.Drawing.Color.LightSalmon;
            this.btnShowAllStocks.Location = new System.Drawing.Point(42, 59);
            this.btnShowAllStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(219, 51);
            this.btnShowAllStocks.TabIndex = 23;
            this.btnShowAllStocks.Text = "Show all stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = false;
            this.btnShowAllStocks.Click += new System.EventHandler(this.BtnShowAllStocks_Click);
            // 
            // gbxSearchStock
            // 
            this.gbxSearchStock.Controls.Add(this.tbxSearchStock);
            this.gbxSearchStock.Location = new System.Drawing.Point(333, 21);
            this.gbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchStock.Name = "gbxSearchStock";
            this.gbxSearchStock.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchStock.Size = new System.Drawing.Size(403, 126);
            this.gbxSearchStock.TabIndex = 22;
            this.gbxSearchStock.TabStop = false;
            this.gbxSearchStock.Text = "Search for specific stock";
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchStock.Location = new System.Drawing.Point(11, 50);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(344, 27);
            this.tbxSearchStock.TabIndex = 7;
            this.tbxSearchStock.TextChanged += new System.EventHandler(this.tbxSearchStock_TextChanged);
            // 
            // btnStocksClearSelected
            // 
            this.btnStocksClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStocksClearSelected.Location = new System.Drawing.Point(42, 564);
            this.btnStocksClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStocksClearSelected.Name = "btnStocksClearSelected";
            this.btnStocksClearSelected.Size = new System.Drawing.Size(219, 60);
            this.btnStocksClearSelected.TabIndex = 21;
            this.btnStocksClearSelected.Text = "Unmark selected";
            this.btnStocksClearSelected.UseVisualStyleBackColor = false;
            this.btnStocksClearSelected.Click += new System.EventHandler(this.btnStocksClearSelected_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditStock.Location = new System.Drawing.Point(542, 564);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(219, 60);
            this.btnEditStock.TabIndex = 20;
            this.btnEditStock.Text = "Edit stock";
            this.btnEditStock.UseVisualStyleBackColor = false;
            this.btnEditStock.Click += new System.EventHandler(this.BtnEditStock_Click);
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveStock.Location = new System.Drawing.Point(779, 564);
            this.btnRemoveStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(219, 60);
            this.btnRemoveStock.TabIndex = 19;
            this.btnRemoveStock.Text = "Remove stock";
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // SchedulingTab
            // 
            this.SchedulingTab.Controls.Add(this.tabControl1);
            this.SchedulingTab.Location = new System.Drawing.Point(4, 29);
            this.SchedulingTab.Name = "SchedulingTab";
            this.SchedulingTab.Size = new System.Drawing.Size(1097, 699);
            this.SchedulingTab.TabIndex = 7;
            this.SchedulingTab.Text = "Scheduling";
            this.SchedulingTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWeeklySchedule);
            this.tabControl1.Controls.Add(this.tpCreateSchedule);
            this.tabControl1.Controls.Add(this.tpManageAttendance);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 820);
            this.tabControl1.TabIndex = 0;
            // 
            // tbWeeklySchedule
            // 
            this.tbWeeklySchedule.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tbWeeklySchedule.Controls.Add(this.cbFilterAttended);
            this.tbWeeklySchedule.Controls.Add(this.cbFilterWFH);
            this.tbWeeklySchedule.Controls.Add(this.btnRemShift);
            this.tbWeeklySchedule.Controls.Add(this.dgvSchedule);
            this.tbWeeklySchedule.Controls.Add(this.lbWeekNumber);
            this.tbWeeklySchedule.Controls.Add(this.cbWeekNumber);
            this.tbWeeklySchedule.Location = new System.Drawing.Point(4, 29);
            this.tbWeeklySchedule.Name = "tbWeeklySchedule";
            this.tbWeeklySchedule.Size = new System.Drawing.Size(1084, 787);
            this.tbWeeklySchedule.TabIndex = 3;
            this.tbWeeklySchedule.Text = "Weekly schedule";
            // 
            // cbFilterAttended
            // 
            this.cbFilterAttended.AutoSize = true;
            this.cbFilterAttended.Location = new System.Drawing.Point(260, 60);
            this.cbFilterAttended.Name = "cbFilterAttended";
            this.cbFilterAttended.Size = new System.Drawing.Size(93, 24);
            this.cbFilterAttended.TabIndex = 30;
            this.cbFilterAttended.Text = "Attended";
            this.cbFilterAttended.UseVisualStyleBackColor = true;
            this.cbFilterAttended.CheckedChanged += new System.EventHandler(this.cbFilterAttended_CheckedChanged);
            // 
            // cbFilterWFH
            // 
            this.cbFilterWFH.AutoSize = true;
            this.cbFilterWFH.Location = new System.Drawing.Point(191, 60);
            this.cbFilterWFH.Name = "cbFilterWFH";
            this.cbFilterWFH.Size = new System.Drawing.Size(63, 24);
            this.cbFilterWFH.TabIndex = 29;
            this.cbFilterWFH.Text = "WFH";
            this.cbFilterWFH.UseVisualStyleBackColor = true;
            this.cbFilterWFH.CheckedChanged += new System.EventHandler(this.cbFilterWFH_CheckedChanged);
            // 
            // btnRemShift
            // 
            this.btnRemShift.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemShift.Location = new System.Drawing.Point(64, 558);
            this.btnRemShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemShift.Name = "btnRemShift";
            this.btnRemShift.Size = new System.Drawing.Size(261, 49);
            this.btnRemShift.TabIndex = 28;
            this.btnRemShift.Text = "Remove selected";
            this.btnRemShift.UseVisualStyleBackColor = false;
            this.btnRemShift.Click += new System.EventHandler(this.btnRemShift_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colEmp,
            this.colDatee,
            this.colType,
            this.colWFH,
            this.colAssignedBy,
            this.colAttended,
            this.colNSR});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedule.Location = new System.Drawing.Point(13, 120);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(1054, 388);
            this.dgvSchedule.TabIndex = 12;
            // 
            // colID
            // 
            this.colID.FillWeight = 42.35764F;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colEmp
            // 
            this.colEmp.FillWeight = 96.49577F;
            this.colEmp.HeaderText = "Employee";
            this.colEmp.MinimumWidth = 6;
            this.colEmp.Name = "colEmp";
            this.colEmp.ReadOnly = true;
            this.colEmp.Width = 125;
            // 
            // colDatee
            // 
            this.colDatee.FillWeight = 70.16822F;
            this.colDatee.HeaderText = "Date";
            this.colDatee.MinimumWidth = 6;
            this.colDatee.Name = "colDatee";
            this.colDatee.ReadOnly = true;
            this.colDatee.Width = 125;
            // 
            // colType
            // 
            this.colType.FillWeight = 76.12518F;
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 125;
            // 
            // colWFH
            // 
            this.colWFH.FillWeight = 56.31413F;
            this.colWFH.HeaderText = "WFH";
            this.colWFH.MinimumWidth = 6;
            this.colWFH.Name = "colWFH";
            this.colWFH.ReadOnly = true;
            this.colWFH.Width = 125;
            // 
            // colAssignedBy
            // 
            this.colAssignedBy.FillWeight = 154.9191F;
            this.colAssignedBy.HeaderText = "Assigned by";
            this.colAssignedBy.MinimumWidth = 6;
            this.colAssignedBy.Name = "colAssignedBy";
            this.colAssignedBy.ReadOnly = true;
            this.colAssignedBy.Width = 125;
            // 
            // colAttended
            // 
            this.colAttended.FillWeight = 102.3382F;
            this.colAttended.HeaderText = "Attended";
            this.colAttended.MinimumWidth = 6;
            this.colAttended.Name = "colAttended";
            this.colAttended.ReadOnly = true;
            this.colAttended.Width = 125;
            // 
            // colNSR
            // 
            this.colNSR.FillWeight = 201.2818F;
            this.colNSR.HeaderText = "No show reason";
            this.colNSR.MinimumWidth = 6;
            this.colNSR.Name = "colNSR";
            this.colNSR.ReadOnly = true;
            this.colNSR.Width = 125;
            // 
            // lbWeekNumber
            // 
            this.lbWeekNumber.AutoSize = true;
            this.lbWeekNumber.Location = new System.Drawing.Point(48, 35);
            this.lbWeekNumber.Name = "lbWeekNumber";
            this.lbWeekNumber.Size = new System.Drawing.Size(48, 20);
            this.lbWeekNumber.TabIndex = 5;
            this.lbWeekNumber.Text = "Week:";
            // 
            // cbWeekNumber
            // 
            this.cbWeekNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbWeekNumber.FormattingEnabled = true;
            this.cbWeekNumber.Location = new System.Drawing.Point(52, 58);
            this.cbWeekNumber.Name = "cbWeekNumber";
            this.cbWeekNumber.Size = new System.Drawing.Size(108, 28);
            this.cbWeekNumber.TabIndex = 4;
            this.cbWeekNumber.SelectedIndexChanged += new System.EventHandler(this.cbWeekNumber_SelectedIndexChanged);
            // 
            // tpCreateSchedule
            // 
            this.tpCreateSchedule.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tpCreateSchedule.Controls.Add(this.gbAutoSch);
            this.tpCreateSchedule.Controls.Add(this.gbAssignShiftManually);
            this.tpCreateSchedule.Controls.Add(this.btnManShifts);
            this.tpCreateSchedule.Controls.Add(this.btnAutoShifts);
            this.tpCreateSchedule.Location = new System.Drawing.Point(4, 29);
            this.tpCreateSchedule.Name = "tpCreateSchedule";
            this.tpCreateSchedule.Size = new System.Drawing.Size(1084, 787);
            this.tpCreateSchedule.TabIndex = 1;
            this.tpCreateSchedule.Text = "Create schedule";
            // 
            // gbAutoSch
            // 
            this.gbAutoSch.Controls.Add(this.lbWeekNrAS);
            this.gbAutoSch.Controls.Add(this.btnGenAS);
            this.gbAutoSch.Controls.Add(this.cbWeekAS);
            this.gbAutoSch.Controls.Add(this.btnGoBackAuto);
            this.gbAutoSch.Controls.Add(this.lbASHinfo);
            this.gbAutoSch.Location = new System.Drawing.Point(34, 193);
            this.gbAutoSch.Name = "gbAutoSch";
            this.gbAutoSch.Size = new System.Drawing.Size(284, 382);
            this.gbAutoSch.TabIndex = 30;
            this.gbAutoSch.TabStop = false;
            this.gbAutoSch.Text = "Automated schedule";
            this.gbAutoSch.Visible = false;
            // 
            // lbWeekNrAS
            // 
            this.lbWeekNrAS.AutoSize = true;
            this.lbWeekNrAS.Location = new System.Drawing.Point(87, 146);
            this.lbWeekNrAS.Name = "lbWeekNrAS";
            this.lbWeekNrAS.Size = new System.Drawing.Size(48, 20);
            this.lbWeekNrAS.TabIndex = 32;
            this.lbWeekNrAS.Text = "Week:";
            // 
            // btnGenAS
            // 
            this.btnGenAS.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGenAS.Location = new System.Drawing.Point(66, 211);
            this.btnGenAS.Name = "btnGenAS";
            this.btnGenAS.Size = new System.Drawing.Size(170, 39);
            this.btnGenAS.TabIndex = 33;
            this.btnGenAS.Text = "Generate schedule";
            this.btnGenAS.UseVisualStyleBackColor = false;
            this.btnGenAS.Click += new System.EventHandler(this.btnGenAS_Click);
            // 
            // cbWeekAS
            // 
            this.cbWeekAS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbWeekAS.FormattingEnabled = true;
            this.cbWeekAS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52"});
            this.cbWeekAS.Location = new System.Drawing.Point(91, 171);
            this.cbWeekAS.Name = "cbWeekAS";
            this.cbWeekAS.Size = new System.Drawing.Size(108, 28);
            this.cbWeekAS.TabIndex = 31;
            // 
            // btnGoBackAuto
            // 
            this.btnGoBackAuto.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGoBackAuto.Location = new System.Drawing.Point(100, 293);
            this.btnGoBackAuto.Name = "btnGoBackAuto";
            this.btnGoBackAuto.Size = new System.Drawing.Size(119, 32);
            this.btnGoBackAuto.TabIndex = 30;
            this.btnGoBackAuto.Text = "Go back";
            this.btnGoBackAuto.UseVisualStyleBackColor = false;
            this.btnGoBackAuto.Click += new System.EventHandler(this.btnGoBackAuto_Click);
            // 
            // lbASHinfo
            // 
            this.lbASHinfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbASHinfo.Location = new System.Drawing.Point(22, 35);
            this.lbASHinfo.Name = "lbASHinfo";
            this.lbASHinfo.Size = new System.Drawing.Size(260, 92);
            this.lbASHinfo.TabIndex = 31;
            this.lbASHinfo.Text = "Select a week for which you want to generate schedule.\r\nWarning, all existing shi" +
    "fts for the selected week will be removed and replaced.";
            this.lbASHinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAssignShiftManually
            // 
            this.gbAssignShiftManually.Controls.Add(this.btnGoBackManual);
            this.gbAssignShiftManually.Controls.Add(this.lbEmp);
            this.gbAssignShiftManually.Controls.Add(this.cbWFH);
            this.gbAssignShiftManually.Controls.Add(this.lbDep);
            this.gbAssignShiftManually.Controls.Add(this.lbEmpInfo);
            this.gbAssignShiftManually.Controls.Add(this.lbWFH);
            this.gbAssignShiftManually.Controls.Add(this.cbEmps);
            this.gbAssignShiftManually.Controls.Add(this.cbDeps);
            this.gbAssignShiftManually.Controls.Add(this.btnAssign);
            this.gbAssignShiftManually.Controls.Add(this.lbShiftType);
            this.gbAssignShiftManually.Controls.Add(this.dtpShiftDate);
            this.gbAssignShiftManually.Controls.Add(this.lbShiftDate);
            this.gbAssignShiftManually.Controls.Add(this.cbShiftType);
            this.gbAssignShiftManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAssignShiftManually.Location = new System.Drawing.Point(433, 68);
            this.gbAssignShiftManually.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAssignShiftManually.Name = "gbAssignShiftManually";
            this.gbAssignShiftManually.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAssignShiftManually.Size = new System.Drawing.Size(384, 488);
            this.gbAssignShiftManually.TabIndex = 25;
            this.gbAssignShiftManually.TabStop = false;
            this.gbAssignShiftManually.Text = "Assign work shift";
            this.gbAssignShiftManually.Visible = false;
            // 
            // btnGoBackManual
            // 
            this.btnGoBackManual.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGoBackManual.Location = new System.Drawing.Point(123, 434);
            this.btnGoBackManual.Name = "btnGoBackManual";
            this.btnGoBackManual.Size = new System.Drawing.Size(119, 32);
            this.btnGoBackManual.TabIndex = 31;
            this.btnGoBackManual.Text = "Go back";
            this.btnGoBackManual.UseVisualStyleBackColor = false;
            this.btnGoBackManual.Click += new System.EventHandler(this.btnGoBackManual_Click);
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Location = new System.Drawing.Point(76, 140);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(78, 18);
            this.lbEmp.TabIndex = 5;
            this.lbEmp.Text = "Employee:";
            // 
            // cbWFH
            // 
            this.cbWFH.AutoSize = true;
            this.cbWFH.Location = new System.Drawing.Point(79, 332);
            this.cbWFH.Name = "cbWFH";
            this.cbWFH.Size = new System.Drawing.Size(163, 22);
            this.cbWFH.TabIndex = 9;
            this.cbWFH.Text = "Working from home";
            this.cbWFH.UseVisualStyleBackColor = true;
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Location = new System.Drawing.Point(73, 82);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(89, 18);
            this.lbDep.TabIndex = 4;
            this.lbDep.Text = "Department:";
            // 
            // lbEmpInfo
            // 
            this.lbEmpInfo.AutoSize = true;
            this.lbEmpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmpInfo.Location = new System.Drawing.Point(93, 39);
            this.lbEmpInfo.Name = "lbEmpInfo";
            this.lbEmpInfo.Size = new System.Drawing.Size(206, 28);
            this.lbEmpInfo.TabIndex = 24;
            this.lbEmpInfo.Text = "Employee with Id:(id)";
            // 
            // lbWFH
            // 
            this.lbWFH.AutoSize = true;
            this.lbWFH.Location = new System.Drawing.Point(5, 176);
            this.lbWFH.Name = "lbWFH";
            this.lbWFH.Size = new System.Drawing.Size(0, 18);
            this.lbWFH.TabIndex = 8;
            // 
            // cbEmps
            // 
            this.cbEmps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmps.FormattingEnabled = true;
            this.cbEmps.Location = new System.Drawing.Point(77, 163);
            this.cbEmps.Name = "cbEmps";
            this.cbEmps.Size = new System.Drawing.Size(202, 26);
            this.cbEmps.TabIndex = 1;
            this.cbEmps.SelectedIndexChanged += new System.EventHandler(this.cbEmps_SelectedIndexChanged);
            // 
            // cbDeps
            // 
            this.cbDeps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDeps.FormattingEnabled = true;
            this.cbDeps.Location = new System.Drawing.Point(77, 105);
            this.cbDeps.Name = "cbDeps";
            this.cbDeps.Size = new System.Drawing.Size(202, 26);
            this.cbDeps.TabIndex = 0;
            this.cbDeps.SelectedIndexChanged += new System.EventHandler(this.cbDeps_SelectedIndexChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAssign.Location = new System.Drawing.Point(89, 394);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(210, 39);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign shift to employee";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lbShiftType
            // 
            this.lbShiftType.AutoSize = true;
            this.lbShiftType.Location = new System.Drawing.Point(76, 205);
            this.lbShiftType.Name = "lbShiftType";
            this.lbShiftType.Size = new System.Drawing.Size(72, 18);
            this.lbShiftType.TabIndex = 1;
            this.lbShiftType.Text = "Shift type:";
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(79, 290);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 24);
            this.dtpShiftDate.TabIndex = 6;
            // 
            // lbShiftDate
            // 
            this.lbShiftDate.AutoSize = true;
            this.lbShiftDate.Location = new System.Drawing.Point(76, 268);
            this.lbShiftDate.Name = "lbShiftDate";
            this.lbShiftDate.Size = new System.Drawing.Size(120, 18);
            this.lbShiftDate.TabIndex = 3;
            this.lbShiftDate.Text = "Date for the shift:";
            // 
            // cbShiftType
            // 
            this.cbShiftType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbShiftType.Location = new System.Drawing.Point(79, 227);
            this.cbShiftType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(200, 26);
            this.cbShiftType.TabIndex = 5;
            this.cbShiftType.Text = "Choose shift type";
            // 
            // btnManShifts
            // 
            this.btnManShifts.BackColor = System.Drawing.Color.LightSalmon;
            this.btnManShifts.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManShifts.Location = new System.Drawing.Point(17, 98);
            this.btnManShifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManShifts.Name = "btnManShifts";
            this.btnManShifts.Size = new System.Drawing.Size(301, 71);
            this.btnManShifts.TabIndex = 25;
            this.btnManShifts.Text = "Create schedule manually";
            this.btnManShifts.UseVisualStyleBackColor = false;
            this.btnManShifts.Click += new System.EventHandler(this.btnManShifts_Click);
            // 
            // btnAutoShifts
            // 
            this.btnAutoShifts.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAutoShifts.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoShifts.Location = new System.Drawing.Point(17, 19);
            this.btnAutoShifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutoShifts.Name = "btnAutoShifts";
            this.btnAutoShifts.Size = new System.Drawing.Size(301, 71);
            this.btnAutoShifts.TabIndex = 26;
            this.btnAutoShifts.Text = "Automated schedule";
            this.btnAutoShifts.UseVisualStyleBackColor = false;
            this.btnAutoShifts.Click += new System.EventHandler(this.btnAutoShifts_Click);
            // 
            // tpManageAttendance
            // 
            this.tpManageAttendance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tpManageAttendance.Controls.Add(this.btnApplyAttendanceChanges);
            this.tpManageAttendance.Controls.Add(this.tbReasonForAbsence);
            this.tpManageAttendance.Controls.Add(this.cbHasAttended);
            this.tpManageAttendance.Controls.Add(this.lbReason);
            this.tpManageAttendance.Controls.Add(this.lbHasAttended);
            this.tpManageAttendance.Controls.Add(this.lbShift);
            this.tpManageAttendance.Controls.Add(this.cbEmployeesShifts);
            this.tpManageAttendance.Controls.Add(this.lbSelectedEmp);
            this.tpManageAttendance.Controls.Add(this.lbSelectedDep);
            this.tpManageAttendance.Controls.Add(this.cbSelectedEmp);
            this.tpManageAttendance.Controls.Add(this.cbAllDeps);
            this.tpManageAttendance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpManageAttendance.Location = new System.Drawing.Point(4, 29);
            this.tpManageAttendance.Name = "tpManageAttendance";
            this.tpManageAttendance.Size = new System.Drawing.Size(1084, 787);
            this.tpManageAttendance.TabIndex = 2;
            this.tpManageAttendance.Text = "Manage attendance";
            // 
            // btnApplyAttendanceChanges
            // 
            this.btnApplyAttendanceChanges.BackColor = System.Drawing.Color.OrangeRed;
            this.btnApplyAttendanceChanges.Location = new System.Drawing.Point(395, 385);
            this.btnApplyAttendanceChanges.Name = "btnApplyAttendanceChanges";
            this.btnApplyAttendanceChanges.Size = new System.Drawing.Size(254, 52);
            this.btnApplyAttendanceChanges.TabIndex = 17;
            this.btnApplyAttendanceChanges.Text = "Apply changes";
            this.btnApplyAttendanceChanges.UseVisualStyleBackColor = false;
            this.btnApplyAttendanceChanges.Click += new System.EventHandler(this.btnApplyAttendanceChanges_Click);
            // 
            // tbReasonForAbsence
            // 
            this.tbReasonForAbsence.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbReasonForAbsence.Location = new System.Drawing.Point(395, 340);
            this.tbReasonForAbsence.Name = "tbReasonForAbsence";
            this.tbReasonForAbsence.Size = new System.Drawing.Size(254, 27);
            this.tbReasonForAbsence.TabIndex = 16;
            this.tbReasonForAbsence.Visible = false;
            // 
            // cbHasAttended
            // 
            this.cbHasAttended.AutoSize = true;
            this.cbHasAttended.BackColor = System.Drawing.Color.Transparent;
            this.cbHasAttended.Location = new System.Drawing.Point(395, 290);
            this.cbHasAttended.Name = "cbHasAttended";
            this.cbHasAttended.Size = new System.Drawing.Size(215, 24);
            this.cbHasAttended.TabIndex = 15;
            this.cbHasAttended.Text = "The employee has attended";
            this.cbHasAttended.UseVisualStyleBackColor = false;
            this.cbHasAttended.Visible = false;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(391, 317);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(60, 20);
            this.lbReason.TabIndex = 14;
            this.lbReason.Text = "Reason:";
            this.lbReason.Visible = false;
            // 
            // lbHasAttended
            // 
            this.lbHasAttended.AutoSize = true;
            this.lbHasAttended.Location = new System.Drawing.Point(391, 262);
            this.lbHasAttended.Name = "lbHasAttended";
            this.lbHasAttended.Size = new System.Drawing.Size(74, 20);
            this.lbHasAttended.TabIndex = 13;
            this.lbHasAttended.Text = "Attended:";
            this.lbHasAttended.Visible = false;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Location = new System.Drawing.Point(391, 208);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(42, 20);
            this.lbShift.TabIndex = 12;
            this.lbShift.Text = "Shift:";
            // 
            // cbEmployeesShifts
            // 
            this.cbEmployeesShifts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmployeesShifts.FormattingEnabled = true;
            this.cbEmployeesShifts.Location = new System.Drawing.Point(395, 231);
            this.cbEmployeesShifts.Name = "cbEmployeesShifts";
            this.cbEmployeesShifts.Size = new System.Drawing.Size(254, 28);
            this.cbEmployeesShifts.TabIndex = 10;
            this.cbEmployeesShifts.SelectedIndexChanged += new System.EventHandler(this.cbEmployeesShifts_SelectedIndexChanged);
            // 
            // lbSelectedEmp
            // 
            this.lbSelectedEmp.AutoSize = true;
            this.lbSelectedEmp.Location = new System.Drawing.Point(391, 154);
            this.lbSelectedEmp.Name = "lbSelectedEmp";
            this.lbSelectedEmp.Size = new System.Drawing.Size(78, 20);
            this.lbSelectedEmp.TabIndex = 9;
            this.lbSelectedEmp.Text = "Employee:";
            // 
            // lbSelectedDep
            // 
            this.lbSelectedDep.AutoSize = true;
            this.lbSelectedDep.Location = new System.Drawing.Point(391, 95);
            this.lbSelectedDep.Name = "lbSelectedDep";
            this.lbSelectedDep.Size = new System.Drawing.Size(92, 20);
            this.lbSelectedDep.TabIndex = 8;
            this.lbSelectedDep.Text = "Department:";
            // 
            // cbSelectedEmp
            // 
            this.cbSelectedEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSelectedEmp.FormattingEnabled = true;
            this.cbSelectedEmp.Location = new System.Drawing.Point(395, 177);
            this.cbSelectedEmp.Name = "cbSelectedEmp";
            this.cbSelectedEmp.Size = new System.Drawing.Size(254, 28);
            this.cbSelectedEmp.TabIndex = 7;
            this.cbSelectedEmp.SelectedIndexChanged += new System.EventHandler(this.cbSelectedEmp_SelectedIndexChanged);
            // 
            // cbAllDeps
            // 
            this.cbAllDeps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAllDeps.FormattingEnabled = true;
            this.cbAllDeps.Location = new System.Drawing.Point(395, 118);
            this.cbAllDeps.Name = "cbAllDeps";
            this.cbAllDeps.Size = new System.Drawing.Size(254, 28);
            this.cbAllDeps.TabIndex = 6;
            this.cbAllDeps.SelectedIndexChanged += new System.EventHandler(this.cbAllDeps_SelectedIndexChanged);
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.tabControlEmployees);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 29);
            this.EmployeesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeesTab.Size = new System.Drawing.Size(1097, 699);
            this.EmployeesTab.TabIndex = 1;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // tabControlEmployees
            // 
            this.tabControlEmployees.Controls.Add(this.AddEmpTab);
            this.tabControlEmployees.Controls.Add(this.ManageEmpTab);
            this.tabControlEmployees.Controls.Add(this.EmpExpiredContractTab);
            this.tabControlEmployees.Controls.Add(this.HolidayRequestsTab);
            this.tabControlEmployees.Location = new System.Drawing.Point(0, 8);
            this.tabControlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlEmployees.Name = "tabControlEmployees";
            this.tabControlEmployees.SelectedIndex = 0;
            this.tabControlEmployees.Size = new System.Drawing.Size(1101, 821);
            this.tabControlEmployees.TabIndex = 0;
            this.tabControlEmployees.SelectedIndexChanged += new System.EventHandler(this.tabControlEmployees_SelectedIndexChanged);
            this.tabControlEmployees.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlEmployees_Selected);
            // 
            // AddEmpTab
            // 
            this.AddEmpTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddEmpTab.Controls.Add(this.lbHLRDays);
            this.AddEmpTab.Controls.Add(this.tbxHLRDays);
            this.AddEmpTab.Controls.Add(this.cbxEmpIndefiniteContract);
            this.AddEmpTab.Controls.Add(this.dtpEmpEndDate);
            this.AddEmpTab.Controls.Add(this.lbEmpEndDate);
            this.AddEmpTab.Controls.Add(this.dtpEmpStartDate);
            this.AddEmpTab.Controls.Add(this.lbEmpStartDate);
            this.AddEmpTab.Controls.Add(this.lbEmpNationality);
            this.AddEmpTab.Controls.Add(this.tbxEmpNationality);
            this.AddEmpTab.Controls.Add(this.cbEmConRelation);
            this.AddEmpTab.Controls.Add(this.lbEmConRelation);
            this.AddEmpTab.Controls.Add(this.tbxEmConName);
            this.AddEmpTab.Controls.Add(this.lbEmConName);
            this.AddEmpTab.Controls.Add(this.tbxEmConEmail);
            this.AddEmpTab.Controls.Add(this.lbEmConEmail);
            this.AddEmpTab.Controls.Add(this.tbxEmConPhone);
            this.AddEmpTab.Controls.Add(this.lbEmConPhone);
            this.AddEmpTab.Controls.Add(this.lbEmpEmConDetails);
            this.AddEmpTab.Controls.Add(this.lbEmpBsn);
            this.AddEmpTab.Controls.Add(this.tbxEmpBsn);
            this.AddEmpTab.Controls.Add(this.nudEmpHourlyWages);
            this.AddEmpTab.Controls.Add(this.cbEmpDepartment);
            this.AddEmpTab.Controls.Add(this.lbEmpDepartment);
            this.AddEmpTab.Controls.Add(this.cbEmpEmploymentType);
            this.AddEmpTab.Controls.Add(this.lbEmpJobSpec);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressStreet);
            this.AddEmpTab.Controls.Add(this.lbEmpPersonalInfo);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressStreet);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressCity);
            this.AddEmpTab.Controls.Add(this.cbEmpGender);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressCity);
            this.AddEmpTab.Controls.Add(this.tbxEmpEmail);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressCountry);
            this.AddEmpTab.Controls.Add(this.lbEmpEmail);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressPostCode);
            this.AddEmpTab.Controls.Add(this.label1);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressCountry);
            this.AddEmpTab.Controls.Add(this.dtpEmpDateOfBirth);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressPostCode);
            this.AddEmpTab.Controls.Add(this.btnAddEmpoyee);
            this.AddEmpTab.Controls.Add(this.lbEmpEmployementType);
            this.AddEmpTab.Controls.Add(this.lbEmpDateOfBirth);
            this.AddEmpTab.Controls.Add(this.lbEmpHourlyWages);
            this.AddEmpTab.Controls.Add(this.tbxEmpPhone);
            this.AddEmpTab.Controls.Add(this.lbEmpPhone);
            this.AddEmpTab.Controls.Add(this.lbEmployeeAddress);
            this.AddEmpTab.Controls.Add(this.tbxEmpLname);
            this.AddEmpTab.Controls.Add(this.lbEmpLname);
            this.AddEmpTab.Controls.Add(this.tbxEmpFname);
            this.AddEmpTab.Controls.Add(this.lbEmpFname);
            this.AddEmpTab.Location = new System.Drawing.Point(4, 29);
            this.AddEmpTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpTab.Name = "AddEmpTab";
            this.AddEmpTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpTab.Size = new System.Drawing.Size(1093, 788);
            this.AddEmpTab.TabIndex = 0;
            this.AddEmpTab.Text = "AddEmployees";
            // 
            // cbxEmpIndefiniteContract
            // 
            this.cbxEmpIndefiniteContract.AutoSize = true;
            this.cbxEmpIndefiniteContract.Location = new System.Drawing.Point(265, 420);
            this.cbxEmpIndefiniteContract.Name = "cbxEmpIndefiniteContract";
            this.cbxEmpIndefiniteContract.Size = new System.Drawing.Size(152, 24);
            this.cbxEmpIndefiniteContract.TabIndex = 82;
            this.cbxEmpIndefiniteContract.Text = "Indefinite contract";
            this.cbxEmpIndefiniteContract.UseVisualStyleBackColor = true;
            // 
            // dtpEmpEndDate
            // 
            this.dtpEmpEndDate.Location = new System.Drawing.Point(266, 364);
            this.dtpEmpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpEndDate.Name = "dtpEmpEndDate";
            this.dtpEmpEndDate.Size = new System.Drawing.Size(161, 27);
            this.dtpEmpEndDate.TabIndex = 81;
            // 
            // lbEmpEndDate
            // 
            this.lbEmpEndDate.AutoSize = true;
            this.lbEmpEndDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEndDate.Location = new System.Drawing.Point(261, 333);
            this.lbEmpEndDate.Name = "lbEmpEndDate";
            this.lbEmpEndDate.Size = new System.Drawing.Size(68, 20);
            this.lbEmpEndDate.TabIndex = 80;
            this.lbEmpEndDate.Text = "End date";
            // 
            // dtpEmpStartDate
            // 
            this.dtpEmpStartDate.Location = new System.Drawing.Point(266, 291);
            this.dtpEmpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpStartDate.Name = "dtpEmpStartDate";
            this.dtpEmpStartDate.Size = new System.Drawing.Size(161, 27);
            this.dtpEmpStartDate.TabIndex = 79;
            // 
            // lbEmpStartDate
            // 
            this.lbEmpStartDate.AutoSize = true;
            this.lbEmpStartDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpStartDate.Location = new System.Drawing.Point(261, 262);
            this.lbEmpStartDate.Name = "lbEmpStartDate";
            this.lbEmpStartDate.Size = new System.Drawing.Size(74, 20);
            this.lbEmpStartDate.TabIndex = 78;
            this.lbEmpStartDate.Text = "Start date";
            // 
            // lbEmpNationality
            // 
            this.lbEmpNationality.AutoSize = true;
            this.lbEmpNationality.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpNationality.Location = new System.Drawing.Point(14, 391);
            this.lbEmpNationality.Name = "lbEmpNationality";
            this.lbEmpNationality.Size = new System.Drawing.Size(79, 20);
            this.lbEmpNationality.TabIndex = 72;
            this.lbEmpNationality.Text = "Nationality";
            // 
            // tbxEmpNationality
            // 
            this.tbxEmpNationality.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpNationality.Location = new System.Drawing.Point(19, 420);
            this.tbxEmpNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpNationality.Name = "tbxEmpNationality";
            this.tbxEmpNationality.Size = new System.Drawing.Size(161, 27);
            this.tbxEmpNationality.TabIndex = 73;
            // 
            // cbEmConRelation
            // 
            this.cbEmConRelation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmConRelation.FormattingEnabled = true;
            this.cbEmConRelation.Items.AddRange(new object[] {
            "Family",
            "Friend",
            "Colleague",
            "Other"});
            this.cbEmConRelation.Location = new System.Drawing.Point(757, 154);
            this.cbEmConRelation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmConRelation.Name = "cbEmConRelation";
            this.cbEmConRelation.Size = new System.Drawing.Size(167, 28);
            this.cbEmConRelation.TabIndex = 58;
            // 
            // lbEmConRelation
            // 
            this.lbEmConRelation.AutoSize = true;
            this.lbEmConRelation.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConRelation.Location = new System.Drawing.Point(752, 131);
            this.lbEmConRelation.Name = "lbEmConRelation";
            this.lbEmConRelation.Size = new System.Drawing.Size(62, 20);
            this.lbEmConRelation.TabIndex = 56;
            this.lbEmConRelation.Text = "Relation";
            // 
            // tbxEmConName
            // 
            this.tbxEmConName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConName.Location = new System.Drawing.Point(756, 99);
            this.tbxEmConName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConName.Name = "tbxEmConName";
            this.tbxEmConName.Size = new System.Drawing.Size(168, 27);
            this.tbxEmConName.TabIndex = 55;
            // 
            // lbEmConName
            // 
            this.lbEmConName.AutoSize = true;
            this.lbEmConName.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConName.Location = new System.Drawing.Point(752, 75);
            this.lbEmConName.Name = "lbEmConName";
            this.lbEmConName.Size = new System.Drawing.Size(49, 20);
            this.lbEmConName.TabIndex = 54;
            this.lbEmConName.Text = "Name";
            // 
            // tbxEmConEmail
            // 
            this.tbxEmConEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConEmail.Location = new System.Drawing.Point(756, 220);
            this.tbxEmConEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConEmail.Name = "tbxEmConEmail";
            this.tbxEmConEmail.Size = new System.Drawing.Size(168, 27);
            this.tbxEmConEmail.TabIndex = 61;
            // 
            // lbEmConEmail
            // 
            this.lbEmConEmail.AutoSize = true;
            this.lbEmConEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConEmail.Location = new System.Drawing.Point(755, 196);
            this.lbEmConEmail.Name = "lbEmConEmail";
            this.lbEmConEmail.Size = new System.Drawing.Size(44, 20);
            this.lbEmConEmail.TabIndex = 57;
            this.lbEmConEmail.Text = "Email";
            // 
            // tbxEmConPhone
            // 
            this.tbxEmConPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConPhone.Location = new System.Drawing.Point(756, 284);
            this.tbxEmConPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConPhone.Name = "tbxEmConPhone";
            this.tbxEmConPhone.Size = new System.Drawing.Size(168, 27);
            this.tbxEmConPhone.TabIndex = 59;
            // 
            // lbEmConPhone
            // 
            this.lbEmConPhone.AutoSize = true;
            this.lbEmConPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConPhone.Location = new System.Drawing.Point(755, 260);
            this.lbEmConPhone.Name = "lbEmConPhone";
            this.lbEmConPhone.Size = new System.Drawing.Size(50, 20);
            this.lbEmConPhone.TabIndex = 60;
            this.lbEmConPhone.Text = "Phone";
            // 
            // lbEmpEmConDetails
            // 
            this.lbEmpEmConDetails.AutoSize = true;
            this.lbEmpEmConDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmConDetails.Location = new System.Drawing.Point(754, 35);
            this.lbEmpEmConDetails.Name = "lbEmpEmConDetails";
            this.lbEmpEmConDetails.Size = new System.Drawing.Size(249, 28);
            this.lbEmpEmConDetails.TabIndex = 63;
            this.lbEmpEmConDetails.Text = "Emergency contact details";
            // 
            // lbEmpBsn
            // 
            this.lbEmpBsn.AutoSize = true;
            this.lbEmpBsn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpBsn.Location = new System.Drawing.Point(15, 325);
            this.lbEmpBsn.Name = "lbEmpBsn";
            this.lbEmpBsn.Size = new System.Drawing.Size(36, 20);
            this.lbEmpBsn.TabIndex = 52;
            this.lbEmpBsn.Text = "BSN";
            // 
            // tbxEmpBsn
            // 
            this.tbxEmpBsn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpBsn.Location = new System.Drawing.Point(19, 349);
            this.tbxEmpBsn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpBsn.Name = "tbxEmpBsn";
            this.tbxEmpBsn.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpBsn.TabIndex = 53;
            // 
            // nudEmpHourlyWages
            // 
            this.nudEmpHourlyWages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudEmpHourlyWages.Location = new System.Drawing.Point(265, 159);
            this.nudEmpHourlyWages.Name = "nudEmpHourlyWages";
            this.nudEmpHourlyWages.Size = new System.Drawing.Size(160, 27);
            this.nudEmpHourlyWages.TabIndex = 35;
            this.nudEmpHourlyWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEmpHourlyWages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbEmpDepartment
            // 
            this.cbEmpDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpDepartment.FormattingEnabled = true;
            this.cbEmpDepartment.Location = new System.Drawing.Point(265, 222);
            this.cbEmpDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpDepartment.Name = "cbEmpDepartment";
            this.cbEmpDepartment.Size = new System.Drawing.Size(160, 28);
            this.cbEmpDepartment.TabIndex = 37;
            // 
            // lbEmpDepartment
            // 
            this.lbEmpDepartment.AutoSize = true;
            this.lbEmpDepartment.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpDepartment.Location = new System.Drawing.Point(261, 198);
            this.lbEmpDepartment.Name = "lbEmpDepartment";
            this.lbEmpDepartment.Size = new System.Drawing.Size(88, 20);
            this.lbEmpDepartment.TabIndex = 38;
            this.lbEmpDepartment.Text = "Department";
            // 
            // cbEmpEmploymentType
            // 
            this.cbEmpEmploymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Full-time",
            "Part-time"});
            this.cbEmpEmploymentType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpEmploymentType.FormattingEnabled = true;
            this.cbEmpEmploymentType.Items.AddRange(new object[] {
            "FULLTIME",
            "PARTTIME1",
            "PARTTIME2"});
            this.cbEmpEmploymentType.Location = new System.Drawing.Point(265, 102);
            this.cbEmpEmploymentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpEmploymentType.Name = "cbEmpEmploymentType";
            this.cbEmpEmploymentType.Size = new System.Drawing.Size(160, 28);
            this.cbEmpEmploymentType.TabIndex = 32;
            // 
            // lbEmpJobSpec
            // 
            this.lbEmpJobSpec.AutoSize = true;
            this.lbEmpJobSpec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpJobSpec.Location = new System.Drawing.Point(260, 35);
            this.lbEmpJobSpec.Name = "lbEmpJobSpec";
            this.lbEmpJobSpec.Size = new System.Drawing.Size(172, 28);
            this.lbEmpJobSpec.TabIndex = 33;
            this.lbEmpJobSpec.Text = "Job specifications";
            // 
            // lbEmpAddressStreet
            // 
            this.lbEmpAddressStreet.AutoSize = true;
            this.lbEmpAddressStreet.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressStreet.Location = new System.Drawing.Point(498, 195);
            this.lbEmpAddressStreet.Name = "lbEmpAddressStreet";
            this.lbEmpAddressStreet.Size = new System.Drawing.Size(181, 20);
            this.lbEmpAddressStreet.TabIndex = 45;
            this.lbEmpAddressStreet.Text = "Address(Street + Number)";
            // 
            // lbEmpPersonalInfo
            // 
            this.lbEmpPersonalInfo.AutoSize = true;
            this.lbEmpPersonalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpPersonalInfo.Location = new System.Drawing.Point(13, 35);
            this.lbEmpPersonalInfo.Name = "lbEmpPersonalInfo";
            this.lbEmpPersonalInfo.Size = new System.Drawing.Size(202, 28);
            this.lbEmpPersonalInfo.TabIndex = 25;
            this.lbEmpPersonalInfo.Text = "Personal information";
            // 
            // tbxEmpAddressStreet
            // 
            this.tbxEmpAddressStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressStreet.Location = new System.Drawing.Point(502, 221);
            this.tbxEmpAddressStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressStreet.Name = "tbxEmpAddressStreet";
            this.tbxEmpAddressStreet.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpAddressStreet.TabIndex = 44;
            // 
            // tbxEmpAddressCity
            // 
            this.tbxEmpAddressCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressCity.Location = new System.Drawing.Point(502, 284);
            this.tbxEmpAddressCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressCity.Name = "tbxEmpAddressCity";
            this.tbxEmpAddressCity.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpAddressCity.TabIndex = 46;
            // 
            // cbEmpGender
            // 
            this.cbEmpGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpGender.FormattingEnabled = true;
            this.cbEmpGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "NONBINARY",
            "OTHER"});
            this.cbEmpGender.Location = new System.Drawing.Point(19, 289);
            this.cbEmpGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpGender.Name = "cbEmpGender";
            this.cbEmpGender.Size = new System.Drawing.Size(161, 28);
            this.cbEmpGender.TabIndex = 31;
            this.cbEmpGender.Text = "Choose gender";
            // 
            // lbEmpAddressCity
            // 
            this.lbEmpAddressCity.AutoSize = true;
            this.lbEmpAddressCity.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressCity.Location = new System.Drawing.Point(498, 259);
            this.lbEmpAddressCity.Name = "lbEmpAddressCity";
            this.lbEmpAddressCity.Size = new System.Drawing.Size(33, 20);
            this.lbEmpAddressCity.TabIndex = 47;
            this.lbEmpAddressCity.Text = "City";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpEmail.Location = new System.Drawing.Point(502, 98);
            this.tbxEmpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpEmail.TabIndex = 41;
            // 
            // tbxEmpAddressCountry
            // 
            this.tbxEmpAddressCountry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressCountry.Location = new System.Drawing.Point(502, 349);
            this.tbxEmpAddressCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressCountry.Name = "tbxEmpAddressCountry";
            this.tbxEmpAddressCountry.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpAddressCountry.TabIndex = 48;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmail.Location = new System.Drawing.Point(498, 74);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(44, 20);
            this.lbEmpEmail.TabIndex = 39;
            this.lbEmpEmail.Text = "Email";
            // 
            // lbEmpAddressPostCode
            // 
            this.lbEmpAddressPostCode.AutoSize = true;
            this.lbEmpAddressPostCode.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressPostCode.Location = new System.Drawing.Point(498, 389);
            this.lbEmpAddressPostCode.Name = "lbEmpAddressPostCode";
            this.lbEmpAddressPostCode.Size = new System.Drawing.Size(71, 20);
            this.lbEmpAddressPostCode.TabIndex = 50;
            this.lbEmpAddressPostCode.Text = "PostCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gender";
            // 
            // lbEmpAddressCountry
            // 
            this.lbEmpAddressCountry.AutoSize = true;
            this.lbEmpAddressCountry.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressCountry.Location = new System.Drawing.Point(498, 325);
            this.lbEmpAddressCountry.Name = "lbEmpAddressCountry";
            this.lbEmpAddressCountry.Size = new System.Drawing.Size(61, 20);
            this.lbEmpAddressCountry.TabIndex = 49;
            this.lbEmpAddressCountry.Text = "Country";
            // 
            // dtpEmpDateOfBirth
            // 
            this.dtpEmpDateOfBirth.Location = new System.Drawing.Point(22, 225);
            this.dtpEmpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpDateOfBirth.Name = "dtpEmpDateOfBirth";
            this.dtpEmpDateOfBirth.Size = new System.Drawing.Size(161, 27);
            this.dtpEmpDateOfBirth.TabIndex = 29;
            // 
            // tbxEmpAddressPostCode
            // 
            this.tbxEmpAddressPostCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressPostCode.Location = new System.Drawing.Point(502, 420);
            this.tbxEmpAddressPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressPostCode.Name = "tbxEmpAddressPostCode";
            this.tbxEmpAddressPostCode.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpAddressPostCode.TabIndex = 51;
            // 
            // btnAddEmpoyee
            // 
            this.btnAddEmpoyee.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddEmpoyee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddEmpoyee.Location = new System.Drawing.Point(391, 554);
            this.btnAddEmpoyee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmpoyee.Name = "btnAddEmpoyee";
            this.btnAddEmpoyee.Size = new System.Drawing.Size(303, 63);
            this.btnAddEmpoyee.TabIndex = 62;
            this.btnAddEmpoyee.Text = "Add employee";
            this.btnAddEmpoyee.UseVisualStyleBackColor = false;
            this.btnAddEmpoyee.Click += new System.EventHandler(this.btnAddEmpoyee_Click);
            // 
            // lbEmpEmployementType
            // 
            this.lbEmpEmployementType.AutoSize = true;
            this.lbEmpEmployementType.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmployementType.Location = new System.Drawing.Point(261, 77);
            this.lbEmpEmployementType.Name = "lbEmpEmployementType";
            this.lbEmpEmployementType.Size = new System.Drawing.Size(112, 20);
            this.lbEmpEmployementType.TabIndex = 34;
            this.lbEmpEmployementType.Text = "Eployment type";
            // 
            // lbEmpDateOfBirth
            // 
            this.lbEmpDateOfBirth.AutoSize = true;
            this.lbEmpDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpDateOfBirth.Location = new System.Drawing.Point(18, 201);
            this.lbEmpDateOfBirth.Name = "lbEmpDateOfBirth";
            this.lbEmpDateOfBirth.Size = new System.Drawing.Size(91, 20);
            this.lbEmpDateOfBirth.TabIndex = 28;
            this.lbEmpDateOfBirth.Text = "Date of birth";
            // 
            // lbEmpHourlyWages
            // 
            this.lbEmpHourlyWages.AutoSize = true;
            this.lbEmpHourlyWages.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpHourlyWages.Location = new System.Drawing.Point(261, 136);
            this.lbEmpHourlyWages.Name = "lbEmpHourlyWages";
            this.lbEmpHourlyWages.Size = new System.Drawing.Size(138, 20);
            this.lbEmpHourlyWages.TabIndex = 36;
            this.lbEmpHourlyWages.Text = "Hourly wages (euro)";
            // 
            // tbxEmpPhone
            // 
            this.tbxEmpPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpPhone.Location = new System.Drawing.Point(502, 154);
            this.tbxEmpPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpPhone.Name = "tbxEmpPhone";
            this.tbxEmpPhone.Size = new System.Drawing.Size(168, 27);
            this.tbxEmpPhone.TabIndex = 43;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpPhone.Location = new System.Drawing.Point(498, 130);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(50, 20);
            this.lbEmpPhone.TabIndex = 42;
            this.lbEmpPhone.Text = "Phone";
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeAddress.Location = new System.Drawing.Point(497, 35);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(146, 28);
            this.lbEmployeeAddress.TabIndex = 40;
            this.lbEmployeeAddress.Text = "Contact details";
            // 
            // tbxEmpLname
            // 
            this.tbxEmpLname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpLname.Location = new System.Drawing.Point(22, 160);
            this.tbxEmpLname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpLname.Name = "tbxEmpLname";
            this.tbxEmpLname.Size = new System.Drawing.Size(160, 27);
            this.tbxEmpLname.TabIndex = 27;
            // 
            // lbEmpLname
            // 
            this.lbEmpLname.AutoSize = true;
            this.lbEmpLname.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpLname.Location = new System.Drawing.Point(18, 136);
            this.lbEmpLname.Name = "lbEmpLname";
            this.lbEmpLname.Size = new System.Drawing.Size(76, 20);
            this.lbEmpLname.TabIndex = 26;
            this.lbEmpLname.Text = "Last name";
            // 
            // tbxEmpFname
            // 
            this.tbxEmpFname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpFname.Location = new System.Drawing.Point(22, 98);
            this.tbxEmpFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpFname.Name = "tbxEmpFname";
            this.tbxEmpFname.Size = new System.Drawing.Size(160, 27);
            this.tbxEmpFname.TabIndex = 24;
            // 
            // lbEmpFname
            // 
            this.lbEmpFname.AutoSize = true;
            this.lbEmpFname.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpFname.Location = new System.Drawing.Point(17, 74);
            this.lbEmpFname.Name = "lbEmpFname";
            this.lbEmpFname.Size = new System.Drawing.Size(76, 20);
            this.lbEmpFname.TabIndex = 23;
            this.lbEmpFname.Text = "First name";
            // 
            // ManageEmpTab
            // 
            this.ManageEmpTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ManageEmpTab.Controls.Add(this.dgvEmployees);
            this.ManageEmpTab.Controls.Add(this.gbxShowEmp);
            this.ManageEmpTab.Controls.Add(this.gbxSearchEmp);
            this.ManageEmpTab.Controls.Add(this.btnClearSelectedEmp);
            this.ManageEmpTab.Controls.Add(this.btnEditEmp);
            this.ManageEmpTab.Controls.Add(this.btnRemoveEmp);
            this.ManageEmpTab.Location = new System.Drawing.Point(4, 29);
            this.ManageEmpTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageEmpTab.Name = "ManageEmpTab";
            this.ManageEmpTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageEmpTab.Size = new System.Drawing.Size(1093, 788);
            this.ManageEmpTab.TabIndex = 1;
            this.ManageEmpTab.Text = "Manage employees";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(35, 176);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 62;
            this.dgvEmployees.RowTemplate.Height = 28;
            this.dgvEmployees.Size = new System.Drawing.Size(998, 352);
            this.dgvEmployees.TabIndex = 20;
            // 
            // gbxShowEmp
            // 
            this.gbxShowEmp.Controls.Add(this.cbSelectEmpDepartment);
            this.gbxShowEmp.Location = new System.Drawing.Point(35, 24);
            this.gbxShowEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxShowEmp.Name = "gbxShowEmp";
            this.gbxShowEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxShowEmp.Size = new System.Drawing.Size(454, 126);
            this.gbxShowEmp.TabIndex = 19;
            this.gbxShowEmp.TabStop = false;
            this.gbxShowEmp.Text = "Show employees by department";
            // 
            // cbSelectEmpDepartment
            // 
            this.cbSelectEmpDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSelectEmpDepartment.FormattingEnabled = true;
            this.cbSelectEmpDepartment.Items.AddRange(new object[] {
            "All",
            "Administration",
            "Management",
            "Sales",
            "Depot"});
            this.cbSelectEmpDepartment.Location = new System.Drawing.Point(21, 51);
            this.cbSelectEmpDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSelectEmpDepartment.Name = "cbSelectEmpDepartment";
            this.cbSelectEmpDepartment.Size = new System.Drawing.Size(209, 28);
            this.cbSelectEmpDepartment.TabIndex = 8;
            this.cbSelectEmpDepartment.Text = "All";
            this.cbSelectEmpDepartment.SelectedIndexChanged += new System.EventHandler(this.cbSelectEmpDepartment_SelectedIndexChanged);
            // 
            // gbxSearchEmp
            // 
            this.gbxSearchEmp.BackColor = System.Drawing.Color.Transparent;
            this.gbxSearchEmp.Controls.Add(this.tbxSearchEmp);
            this.gbxSearchEmp.Location = new System.Drawing.Point(528, 24);
            this.gbxSearchEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchEmp.Name = "gbxSearchEmp";
            this.gbxSearchEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchEmp.Size = new System.Drawing.Size(505, 126);
            this.gbxSearchEmp.TabIndex = 17;
            this.gbxSearchEmp.TabStop = false;
            this.gbxSearchEmp.Text = "Search for specific employee";
            // 
            // tbxSearchEmp
            // 
            this.tbxSearchEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchEmp.Location = new System.Drawing.Point(14, 53);
            this.tbxSearchEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchEmp.Name = "tbxSearchEmp";
            this.tbxSearchEmp.Size = new System.Drawing.Size(247, 27);
            this.tbxSearchEmp.TabIndex = 7;
            this.tbxSearchEmp.Text = "Search...";
            this.tbxSearchEmp.Click += new System.EventHandler(this.tbxSearchEmp_Click);
            this.tbxSearchEmp.TextChanged += new System.EventHandler(this.tbxSearchEmp_TextChanged);
            // 
            // btnClearSelectedEmp
            // 
            this.btnClearSelectedEmp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClearSelectedEmp.Location = new System.Drawing.Point(46, 579);
            this.btnClearSelectedEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSelectedEmp.Name = "btnClearSelectedEmp";
            this.btnClearSelectedEmp.Size = new System.Drawing.Size(219, 54);
            this.btnClearSelectedEmp.TabIndex = 15;
            this.btnClearSelectedEmp.Text = "Unmark selected";
            this.btnClearSelectedEmp.UseVisualStyleBackColor = false;
            this.btnClearSelectedEmp.Click += new System.EventHandler(this.btnClearSelectedEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditEmp.Location = new System.Drawing.Point(570, 579);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(219, 54);
            this.btnEditEmp.TabIndex = 14;
            this.btnEditEmp.Text = "Edit employee";
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRemoveEmp.Location = new System.Drawing.Point(814, 579);
            this.btnRemoveEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(219, 54);
            this.btnRemoveEmp.TabIndex = 13;
            this.btnRemoveEmp.Text = "Remove employee";
            this.btnRemoveEmp.UseVisualStyleBackColor = false;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // EmpExpiredContractTab
            // 
            this.EmpExpiredContractTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.EmpExpiredContractTab.Controls.Add(this.gbxEmpRenewContract);
            this.EmpExpiredContractTab.Controls.Add(this.btnEmpExpiredContractUnmarkSelected);
            this.EmpExpiredContractTab.Controls.Add(this.btnEmpRenewContract);
            this.EmpExpiredContractTab.Controls.Add(this.dgvEmployeesExpiredContract);
            this.EmpExpiredContractTab.Location = new System.Drawing.Point(4, 29);
            this.EmpExpiredContractTab.Name = "EmpExpiredContractTab";
            this.EmpExpiredContractTab.Size = new System.Drawing.Size(1093, 788);
            this.EmpExpiredContractTab.TabIndex = 3;
            this.EmpExpiredContractTab.Text = "Employees with expired contract";
            // 
            // gbxEmpRenewContract
            // 
            this.gbxEmpRenewContract.Controls.Add(this.lbEmpIdRenewContract);
            this.gbxEmpRenewContract.Controls.Add(this.lbNamesEmpRenewContract);
            this.gbxEmpRenewContract.Controls.Add(this.btnEmpSubmitChangesNewContract);
            this.gbxEmpRenewContract.Controls.Add(this.cbxEmpMakeNewContractIndefinite);
            this.gbxEmpRenewContract.Controls.Add(this.dtpEndDateNewContract);
            this.gbxEmpRenewContract.Controls.Add(this.lbEmpEndDateNewContract);
            this.gbxEmpRenewContract.Controls.Add(this.dtpEmpStartDateNewContract);
            this.gbxEmpRenewContract.Controls.Add(this.lbEmpStartDateNewContract);
            this.gbxEmpRenewContract.Location = new System.Drawing.Point(806, 36);
            this.gbxEmpRenewContract.Name = "gbxEmpRenewContract";
            this.gbxEmpRenewContract.Size = new System.Drawing.Size(269, 378);
            this.gbxEmpRenewContract.TabIndex = 24;
            this.gbxEmpRenewContract.TabStop = false;
            this.gbxEmpRenewContract.Text = "Renew contract";
            // 
            // lbEmpIdRenewContract
            // 
            this.lbEmpIdRenewContract.AutoSize = true;
            this.lbEmpIdRenewContract.Location = new System.Drawing.Point(16, 35);
            this.lbEmpIdRenewContract.Name = "lbEmpIdRenewContract";
            this.lbEmpIdRenewContract.Size = new System.Drawing.Size(29, 20);
            this.lbEmpIdRenewContract.TabIndex = 89;
            this.lbEmpIdRenewContract.Text = "Id: ";
            // 
            // lbNamesEmpRenewContract
            // 
            this.lbNamesEmpRenewContract.AutoSize = true;
            this.lbNamesEmpRenewContract.Location = new System.Drawing.Point(16, 67);
            this.lbNamesEmpRenewContract.Name = "lbNamesEmpRenewContract";
            this.lbNamesEmpRenewContract.Size = new System.Drawing.Size(221, 20);
            this.lbNamesEmpRenewContract.TabIndex = 88;
            this.lbNamesEmpRenewContract.Text = "Employee: First name Last name";
            // 
            // btnEmpSubmitChangesNewContract
            // 
            this.btnEmpSubmitChangesNewContract.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEmpSubmitChangesNewContract.Location = new System.Drawing.Point(38, 312);
            this.btnEmpSubmitChangesNewContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpSubmitChangesNewContract.Name = "btnEmpSubmitChangesNewContract";
            this.btnEmpSubmitChangesNewContract.Size = new System.Drawing.Size(199, 38);
            this.btnEmpSubmitChangesNewContract.TabIndex = 25;
            this.btnEmpSubmitChangesNewContract.Text = "Renew contract";
            this.btnEmpSubmitChangesNewContract.UseVisualStyleBackColor = false;
            this.btnEmpSubmitChangesNewContract.Click += new System.EventHandler(this.btnEmpSubmitChangesNewContract_Click);
            // 
            // cbxEmpMakeNewContractIndefinite
            // 
            this.cbxEmpMakeNewContractIndefinite.AutoSize = true;
            this.cbxEmpMakeNewContractIndefinite.Location = new System.Drawing.Point(38, 266);
            this.cbxEmpMakeNewContractIndefinite.Name = "cbxEmpMakeNewContractIndefinite";
            this.cbxEmpMakeNewContractIndefinite.Size = new System.Drawing.Size(152, 24);
            this.cbxEmpMakeNewContractIndefinite.TabIndex = 87;
            this.cbxEmpMakeNewContractIndefinite.Text = "Indefinite contract";
            this.cbxEmpMakeNewContractIndefinite.UseVisualStyleBackColor = true;
            // 
            // dtpEndDateNewContract
            // 
            this.dtpEndDateNewContract.Location = new System.Drawing.Point(39, 210);
            this.dtpEndDateNewContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDateNewContract.Name = "dtpEndDateNewContract";
            this.dtpEndDateNewContract.Size = new System.Drawing.Size(198, 27);
            this.dtpEndDateNewContract.TabIndex = 86;
            // 
            // lbEmpEndDateNewContract
            // 
            this.lbEmpEndDateNewContract.AutoSize = true;
            this.lbEmpEndDateNewContract.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEndDateNewContract.Location = new System.Drawing.Point(34, 179);
            this.lbEmpEndDateNewContract.Name = "lbEmpEndDateNewContract";
            this.lbEmpEndDateNewContract.Size = new System.Drawing.Size(68, 20);
            this.lbEmpEndDateNewContract.TabIndex = 85;
            this.lbEmpEndDateNewContract.Text = "End date";
            // 
            // dtpEmpStartDateNewContract
            // 
            this.dtpEmpStartDateNewContract.Location = new System.Drawing.Point(39, 137);
            this.dtpEmpStartDateNewContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpStartDateNewContract.Name = "dtpEmpStartDateNewContract";
            this.dtpEmpStartDateNewContract.Size = new System.Drawing.Size(198, 27);
            this.dtpEmpStartDateNewContract.TabIndex = 84;
            // 
            // lbEmpStartDateNewContract
            // 
            this.lbEmpStartDateNewContract.AutoSize = true;
            this.lbEmpStartDateNewContract.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpStartDateNewContract.Location = new System.Drawing.Point(34, 108);
            this.lbEmpStartDateNewContract.Name = "lbEmpStartDateNewContract";
            this.lbEmpStartDateNewContract.Size = new System.Drawing.Size(74, 20);
            this.lbEmpStartDateNewContract.TabIndex = 83;
            this.lbEmpStartDateNewContract.Text = "Start date";
            // 
            // btnEmpExpiredContractUnmarkSelected
            // 
            this.btnEmpExpiredContractUnmarkSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEmpExpiredContractUnmarkSelected.Location = new System.Drawing.Point(22, 420);
            this.btnEmpExpiredContractUnmarkSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpExpiredContractUnmarkSelected.Name = "btnEmpExpiredContractUnmarkSelected";
            this.btnEmpExpiredContractUnmarkSelected.Size = new System.Drawing.Size(219, 54);
            this.btnEmpExpiredContractUnmarkSelected.TabIndex = 23;
            this.btnEmpExpiredContractUnmarkSelected.Text = "Unmark selected";
            this.btnEmpExpiredContractUnmarkSelected.UseVisualStyleBackColor = false;
            this.btnEmpExpiredContractUnmarkSelected.Click += new System.EventHandler(this.btnEmpExpiredContractUnmarkSelected_Click);
            // 
            // btnEmpRenewContract
            // 
            this.btnEmpRenewContract.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEmpRenewContract.Location = new System.Drawing.Point(295, 420);
            this.btnEmpRenewContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpRenewContract.Name = "btnEmpRenewContract";
            this.btnEmpRenewContract.Size = new System.Drawing.Size(219, 54);
            this.btnEmpRenewContract.TabIndex = 22;
            this.btnEmpRenewContract.Text = "Renew contract";
            this.btnEmpRenewContract.UseVisualStyleBackColor = false;
            this.btnEmpRenewContract.Click += new System.EventHandler(this.btnEmpRenewContract_Click);
            // 
            // dgvEmployeesExpiredContract
            // 
            this.dgvEmployeesExpiredContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployeesExpiredContract.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployeesExpiredContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesExpiredContract.Location = new System.Drawing.Point(22, 47);
            this.dgvEmployeesExpiredContract.Name = "dgvEmployeesExpiredContract";
            this.dgvEmployeesExpiredContract.RowHeadersWidth = 62;
            this.dgvEmployeesExpiredContract.RowTemplate.Height = 28;
            this.dgvEmployeesExpiredContract.Size = new System.Drawing.Size(760, 352);
            this.dgvEmployeesExpiredContract.TabIndex = 21;
            // 
            // HolidayRequestsTab
            // 
            this.HolidayRequestsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HolidayRequestsTab.Controls.Add(this.lblHLRstatus);
            this.HolidayRequestsTab.Controls.Add(this.lbHLR);
            this.HolidayRequestsTab.Controls.Add(this.cbFilterHLR);
            this.HolidayRequestsTab.Controls.Add(this.dgvHLR);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsClearSelected);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsDecline);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsAccept);
            this.HolidayRequestsTab.Location = new System.Drawing.Point(4, 29);
            this.HolidayRequestsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HolidayRequestsTab.Name = "HolidayRequestsTab";
            this.HolidayRequestsTab.Size = new System.Drawing.Size(1093, 788);
            this.HolidayRequestsTab.TabIndex = 2;
            this.HolidayRequestsTab.Text = "Holiday requests";
            // 
            // lblHLRstatus
            // 
            this.lblHLRstatus.AutoSize = true;
            this.lblHLRstatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHLRstatus.Location = new System.Drawing.Point(175, 102);
            this.lblHLRstatus.Name = "lblHLRstatus";
            this.lblHLRstatus.Size = new System.Drawing.Size(230, 23);
            this.lblHLRstatus.TabIndex = 15;
            this.lblHLRstatus.Text = "Filter requests on status >>";
            // 
            // lbHLR
            // 
            this.lbHLR.AutoSize = true;
            this.lbHLR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHLR.Location = new System.Drawing.Point(424, 43);
            this.lbHLR.Name = "lbHLR";
            this.lbHLR.Size = new System.Drawing.Size(227, 28);
            this.lbHLR.TabIndex = 14;
            this.lbHLR.Text = "Holiday leave requests\r\n";
            // 
            // cbFilterHLR
            // 
            this.cbFilterHLR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFilterHLR.FormattingEnabled = true;
            this.cbFilterHLR.Items.AddRange(new object[] {
            "All",
            "InProgress",
            "Accepted",
            "Declined"});
            this.cbFilterHLR.Location = new System.Drawing.Point(455, 102);
            this.cbFilterHLR.Name = "cbFilterHLR";
            this.cbFilterHLR.Size = new System.Drawing.Size(216, 28);
            this.cbFilterHLR.TabIndex = 13;
            this.cbFilterHLR.SelectedIndexChanged += new System.EventHandler(this.cbFilterHLR_SelectedIndexChanged);
            // 
            // dgvHLR
            // 
            this.dgvHLR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHLR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHLR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHLR.Location = new System.Drawing.Point(82, 163);
            this.dgvHLR.Name = "dgvHLR";
            this.dgvHLR.RowHeadersWidth = 51;
            this.dgvHLR.RowTemplate.Height = 24;
            this.dgvHLR.Size = new System.Drawing.Size(969, 370);
            this.dgvHLR.TabIndex = 12;
            // 
            // btnHolidayRequestsClearSelected
            // 
            this.btnHolidayRequestsClearSelected.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnHolidayRequestsClearSelected.Location = new System.Drawing.Point(101, 567);
            this.btnHolidayRequestsClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHolidayRequestsClearSelected.Name = "btnHolidayRequestsClearSelected";
            this.btnHolidayRequestsClearSelected.Size = new System.Drawing.Size(163, 54);
            this.btnHolidayRequestsClearSelected.TabIndex = 8;
            this.btnHolidayRequestsClearSelected.Text = "Unmark selected";
            this.btnHolidayRequestsClearSelected.UseVisualStyleBackColor = false;
            this.btnHolidayRequestsClearSelected.Click += new System.EventHandler(this.btnHolidayRequestsClearSelected_Click);
            // 
            // btnHolidayRequestsDecline
            // 
            this.btnHolidayRequestsDecline.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHolidayRequestsDecline.Location = new System.Drawing.Point(888, 567);
            this.btnHolidayRequestsDecline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHolidayRequestsDecline.Name = "btnHolidayRequestsDecline";
            this.btnHolidayRequestsDecline.Size = new System.Drawing.Size(163, 54);
            this.btnHolidayRequestsDecline.TabIndex = 7;
            this.btnHolidayRequestsDecline.Text = "Decline";
            this.btnHolidayRequestsDecline.UseVisualStyleBackColor = false;
            this.btnHolidayRequestsDecline.Click += new System.EventHandler(this.btnHolidayRequestsDecline_Click);
            // 
            // btnHolidayRequestsAccept
            // 
            this.btnHolidayRequestsAccept.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHolidayRequestsAccept.Location = new System.Drawing.Point(719, 567);
            this.btnHolidayRequestsAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHolidayRequestsAccept.Name = "btnHolidayRequestsAccept";
            this.btnHolidayRequestsAccept.Size = new System.Drawing.Size(163, 54);
            this.btnHolidayRequestsAccept.TabIndex = 6;
            this.btnHolidayRequestsAccept.Text = "Accept";
            this.btnHolidayRequestsAccept.UseVisualStyleBackColor = false;
            this.btnHolidayRequestsAccept.Click += new System.EventHandler(this.btnHolidayRequestsAccept_Click);
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HomeTab.Controls.Add(this.panelEmpExpiredContract);
            this.HomeTab.Controls.Add(this.panelHLRNotifications);
            this.HomeTab.Controls.Add(this.manageDepartmentsShortcut);
            this.HomeTab.Controls.Add(this.manageStockShortcut);
            this.HomeTab.Controls.Add(this.manageAttendanceShortcut);
            this.HomeTab.Controls.Add(this.weeklySchedukeShortcut);
            this.HomeTab.Controls.Add(this.holidayLeaveRequestsShortcut);
            this.HomeTab.Controls.Add(this.manageEmpShortcut);
            this.HomeTab.Controls.Add(this.pictureBox7);
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HomeTab.Location = new System.Drawing.Point(4, 29);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Size = new System.Drawing.Size(1097, 699);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            // 
            // panelEmpExpiredContract
            // 
            this.panelEmpExpiredContract.BackColor = System.Drawing.Color.Red;
            this.panelEmpExpiredContract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmpExpiredContract.Controls.Add(this.lbEmpExpiredContract);
            this.panelEmpExpiredContract.Controls.Add(this.pbxEmpExpiredContract);
            this.panelEmpExpiredContract.Location = new System.Drawing.Point(34, 18);
            this.panelEmpExpiredContract.Name = "panelEmpExpiredContract";
            this.panelEmpExpiredContract.Size = new System.Drawing.Size(632, 63);
            this.panelEmpExpiredContract.TabIndex = 15;
            this.panelEmpExpiredContract.Visible = false;
            // 
            // lbEmpExpiredContract
            // 
            this.lbEmpExpiredContract.AutoSize = true;
            this.lbEmpExpiredContract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpExpiredContract.Location = new System.Drawing.Point(74, 16);
            this.lbEmpExpiredContract.Name = "lbEmpExpiredContract";
            this.lbEmpExpiredContract.Size = new System.Drawing.Size(532, 28);
            this.lbEmpExpiredContract.TabIndex = 1;
            this.lbEmpExpiredContract.Text = "There are 3 people with expired contract (click to manange).";
            this.lbEmpExpiredContract.Click += new System.EventHandler(this.lbEmpExpiredContract_Click);
            // 
            // pbxEmpExpiredContract
            // 
            this.pbxEmpExpiredContract.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxEmpExpiredContract.Image = global::MediaBazaarApp.Properties.Resources.round_circle_notifications_black_48dp;
            this.pbxEmpExpiredContract.Location = new System.Drawing.Point(12, 11);
            this.pbxEmpExpiredContract.Name = "pbxEmpExpiredContract";
            this.pbxEmpExpiredContract.Size = new System.Drawing.Size(56, 44);
            this.pbxEmpExpiredContract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmpExpiredContract.TabIndex = 0;
            this.pbxEmpExpiredContract.TabStop = false;
            // 
            // panelHLRNotifications
            // 
            this.panelHLRNotifications.BackColor = System.Drawing.Color.Red;
            this.panelHLRNotifications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHLRNotifications.Controls.Add(this.lbHLRNotifications);
            this.panelHLRNotifications.Controls.Add(this.pbxHLRNotifications);
            this.panelHLRNotifications.Location = new System.Drawing.Point(34, 102);
            this.panelHLRNotifications.Name = "panelHLRNotifications";
            this.panelHLRNotifications.Size = new System.Drawing.Size(580, 63);
            this.panelHLRNotifications.TabIndex = 13;
            this.panelHLRNotifications.Visible = false;
            // 
            // lbHLRNotifications
            // 
            this.lbHLRNotifications.AutoSize = true;
            this.lbHLRNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHLRNotifications.Location = new System.Drawing.Point(74, 16);
            this.lbHLRNotifications.Name = "lbHLRNotifications";
            this.lbHLRNotifications.Size = new System.Drawing.Size(465, 28);
            this.lbHLRNotifications.TabIndex = 1;
            this.lbHLRNotifications.Text = "There are 3 new holiday requests (click to manange).";
            this.lbHLRNotifications.Click += new System.EventHandler(this.lbHLRNotifications_Click);
            // 
            // pbxHLRNotifications
            // 
            this.pbxHLRNotifications.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxHLRNotifications.Image = global::MediaBazaarApp.Properties.Resources.round_circle_notifications_black_48dp;
            this.pbxHLRNotifications.Location = new System.Drawing.Point(12, 11);
            this.pbxHLRNotifications.Name = "pbxHLRNotifications";
            this.pbxHLRNotifications.Size = new System.Drawing.Size(56, 44);
            this.pbxHLRNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHLRNotifications.TabIndex = 0;
            this.pbxHLRNotifications.TabStop = false;
            // 
            // manageDepartmentsShortcut
            // 
            this.manageDepartmentsShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageDepartmentsShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageDepartmentsShortcut.Controls.Add(this.manageDepLBL);
            this.manageDepartmentsShortcut.Controls.Add(this.manageDepPic);
            this.manageDepartmentsShortcut.Location = new System.Drawing.Point(704, 535);
            this.manageDepartmentsShortcut.Name = "manageDepartmentsShortcut";
            this.manageDepartmentsShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageDepartmentsShortcut.TabIndex = 13;
            this.manageDepartmentsShortcut.Visible = false;
            this.manageDepartmentsShortcut.Click += new System.EventHandler(this.ManageDepartmentsShortcut_Click);
            // 
            // manageDepLBL
            // 
            this.manageDepLBL.AutoSize = true;
            this.manageDepLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepLBL.Location = new System.Drawing.Point(74, 22);
            this.manageDepLBL.Name = "manageDepLBL";
            this.manageDepLBL.Size = new System.Drawing.Size(199, 28);
            this.manageDepLBL.TabIndex = 1;
            this.manageDepLBL.Text = "Manage departments";
            this.manageDepLBL.Click += new System.EventHandler(this.ManageDepLBL_Click);
            // 
            // manageDepPic
            // 
            this.manageDepPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageDepPic.Image = global::MediaBazaarApp.Properties.Resources.round_supervisor_account_black_48dp;
            this.manageDepPic.Location = new System.Drawing.Point(12, 11);
            this.manageDepPic.Name = "manageDepPic";
            this.manageDepPic.Size = new System.Drawing.Size(56, 57);
            this.manageDepPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageDepPic.TabIndex = 0;
            this.manageDepPic.TabStop = false;
            this.manageDepPic.Click += new System.EventHandler(this.ManageDepPic_Click);
            // 
            // manageStockShortcut
            // 
            this.manageStockShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageStockShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageStockShortcut.Controls.Add(this.manageStockLBL);
            this.manageStockShortcut.Controls.Add(this.manageStockPic);
            this.manageStockShortcut.Location = new System.Drawing.Point(704, 448);
            this.manageStockShortcut.Name = "manageStockShortcut";
            this.manageStockShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageStockShortcut.TabIndex = 14;
            this.manageStockShortcut.Visible = false;
            this.manageStockShortcut.Click += new System.EventHandler(this.ManageStockShortcut_Click);
            // 
            // manageStockLBL
            // 
            this.manageStockLBL.AutoSize = true;
            this.manageStockLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStockLBL.Location = new System.Drawing.Point(74, 22);
            this.manageStockLBL.Name = "manageStockLBL";
            this.manageStockLBL.Size = new System.Drawing.Size(134, 28);
            this.manageStockLBL.TabIndex = 1;
            this.manageStockLBL.Text = "Manage stock";
            this.manageStockLBL.Click += new System.EventHandler(this.ManageStockLBL_Click);
            // 
            // manageStockPic
            // 
            this.manageStockPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageStockPic.Image = global::MediaBazaarApp.Properties.Resources.round_shopping_cart_black_48dp;
            this.manageStockPic.Location = new System.Drawing.Point(12, 11);
            this.manageStockPic.Name = "manageStockPic";
            this.manageStockPic.Size = new System.Drawing.Size(56, 57);
            this.manageStockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageStockPic.TabIndex = 0;
            this.manageStockPic.TabStop = false;
            this.manageStockPic.Click += new System.EventHandler(this.ManageStockPic_Click);
            // 
            // manageAttendanceShortcut
            // 
            this.manageAttendanceShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageAttendanceShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageAttendanceShortcut.Controls.Add(this.manageAttendanceLBL);
            this.manageAttendanceShortcut.Controls.Add(this.manageAttendancePic);
            this.manageAttendanceShortcut.Location = new System.Drawing.Point(704, 362);
            this.manageAttendanceShortcut.Name = "manageAttendanceShortcut";
            this.manageAttendanceShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageAttendanceShortcut.TabIndex = 15;
            this.manageAttendanceShortcut.Visible = false;
            this.manageAttendanceShortcut.Click += new System.EventHandler(this.ManageAttendanceShortcut_Click);
            // 
            // manageAttendanceLBL
            // 
            this.manageAttendanceLBL.AutoSize = true;
            this.manageAttendanceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAttendanceLBL.Location = new System.Drawing.Point(74, 22);
            this.manageAttendanceLBL.Name = "manageAttendanceLBL";
            this.manageAttendanceLBL.Size = new System.Drawing.Size(185, 28);
            this.manageAttendanceLBL.TabIndex = 1;
            this.manageAttendanceLBL.Text = "Manage attendance";
            this.manageAttendanceLBL.Click += new System.EventHandler(this.ManageAttendanceLBL_Click);
            // 
            // manageAttendancePic
            // 
            this.manageAttendancePic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageAttendancePic.Image = global::MediaBazaarApp.Properties.Resources.round_event_available_black_48dp;
            this.manageAttendancePic.Location = new System.Drawing.Point(12, 11);
            this.manageAttendancePic.Name = "manageAttendancePic";
            this.manageAttendancePic.Size = new System.Drawing.Size(56, 57);
            this.manageAttendancePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageAttendancePic.TabIndex = 0;
            this.manageAttendancePic.TabStop = false;
            this.manageAttendancePic.Click += new System.EventHandler(this.ManageAttendancePic_Click);
            // 
            // weeklySchedukeShortcut
            // 
            this.weeklySchedukeShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.weeklySchedukeShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weeklySchedukeShortcut.Controls.Add(this.weeklyScheduleLBL);
            this.weeklySchedukeShortcut.Controls.Add(this.weekSchedulePic);
            this.weeklySchedukeShortcut.Location = new System.Drawing.Point(704, 275);
            this.weeklySchedukeShortcut.Name = "weeklySchedukeShortcut";
            this.weeklySchedukeShortcut.Size = new System.Drawing.Size(362, 80);
            this.weeklySchedukeShortcut.TabIndex = 16;
            this.weeklySchedukeShortcut.Visible = false;
            this.weeklySchedukeShortcut.Click += new System.EventHandler(this.WeeklySchedukeShortcut_Click);
            // 
            // weeklyScheduleLBL
            // 
            this.weeklyScheduleLBL.AutoSize = true;
            this.weeklyScheduleLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyScheduleLBL.Location = new System.Drawing.Point(74, 22);
            this.weeklyScheduleLBL.Name = "weeklyScheduleLBL";
            this.weeklyScheduleLBL.Size = new System.Drawing.Size(156, 28);
            this.weeklyScheduleLBL.TabIndex = 1;
            this.weeklyScheduleLBL.Text = "Weekly schedule";
            this.weeklyScheduleLBL.Click += new System.EventHandler(this.WeeklyScheduleLBL_Click);
            // 
            // weekSchedulePic
            // 
            this.weekSchedulePic.Cursor = System.Windows.Forms.Cursors.Default;
            this.weekSchedulePic.Image = global::MediaBazaarApp.Properties.Resources.round_calendar_today_black_48dp;
            this.weekSchedulePic.Location = new System.Drawing.Point(12, 11);
            this.weekSchedulePic.Name = "weekSchedulePic";
            this.weekSchedulePic.Size = new System.Drawing.Size(56, 57);
            this.weekSchedulePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weekSchedulePic.TabIndex = 0;
            this.weekSchedulePic.TabStop = false;
            this.weekSchedulePic.Click += new System.EventHandler(this.WeekSchedulePic_Click);
            // 
            // holidayLeaveRequestsShortcut
            // 
            this.holidayLeaveRequestsShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.holidayLeaveRequestsShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holidayLeaveRequestsShortcut.Controls.Add(this.holidayLeaveLBL);
            this.holidayLeaveRequestsShortcut.Controls.Add(this.holidayLeavePic);
            this.holidayLeaveRequestsShortcut.Location = new System.Drawing.Point(704, 188);
            this.holidayLeaveRequestsShortcut.Name = "holidayLeaveRequestsShortcut";
            this.holidayLeaveRequestsShortcut.Size = new System.Drawing.Size(362, 80);
            this.holidayLeaveRequestsShortcut.TabIndex = 17;
            this.holidayLeaveRequestsShortcut.Visible = false;
            this.holidayLeaveRequestsShortcut.Click += new System.EventHandler(this.HolidayLeaveRequestsShortcut_Click);
            // 
            // holidayLeaveLBL
            // 
            this.holidayLeaveLBL.AutoSize = true;
            this.holidayLeaveLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayLeaveLBL.Location = new System.Drawing.Point(74, 22);
            this.holidayLeaveLBL.Name = "holidayLeaveLBL";
            this.holidayLeaveLBL.Size = new System.Drawing.Size(208, 28);
            this.holidayLeaveLBL.TabIndex = 1;
            this.holidayLeaveLBL.Text = "Holiday leave requests";
            this.holidayLeaveLBL.Click += new System.EventHandler(this.HolidayLeaveLBL_Click);
            // 
            // holidayLeavePic
            // 
            this.holidayLeavePic.Cursor = System.Windows.Forms.Cursors.Default;
            this.holidayLeavePic.Image = global::MediaBazaarApp.Properties.Resources.round_flight_takeoff_black_48dp;
            this.holidayLeavePic.Location = new System.Drawing.Point(12, 11);
            this.holidayLeavePic.Name = "holidayLeavePic";
            this.holidayLeavePic.Size = new System.Drawing.Size(56, 57);
            this.holidayLeavePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.holidayLeavePic.TabIndex = 0;
            this.holidayLeavePic.TabStop = false;
            this.holidayLeavePic.Click += new System.EventHandler(this.HolidayLeavePic_Click);
            // 
            // manageEmpShortcut
            // 
            this.manageEmpShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageEmpShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageEmpShortcut.Controls.Add(this.manageEmpLBL);
            this.manageEmpShortcut.Controls.Add(this.manageEmpPic);
            this.manageEmpShortcut.Location = new System.Drawing.Point(704, 102);
            this.manageEmpShortcut.Name = "manageEmpShortcut";
            this.manageEmpShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageEmpShortcut.TabIndex = 12;
            this.manageEmpShortcut.Visible = false;
            this.manageEmpShortcut.Click += new System.EventHandler(this.ManageEmpShortcut_Click);
            // 
            // manageEmpLBL
            // 
            this.manageEmpLBL.AutoSize = true;
            this.manageEmpLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmpLBL.Location = new System.Drawing.Point(74, 22);
            this.manageEmpLBL.Name = "manageEmpLBL";
            this.manageEmpLBL.Size = new System.Drawing.Size(182, 28);
            this.manageEmpLBL.TabIndex = 1;
            this.manageEmpLBL.Text = "Manage employees";
            this.manageEmpLBL.Click += new System.EventHandler(this.ManageEmpLBL_Click);
            // 
            // manageEmpPic
            // 
            this.manageEmpPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageEmpPic.Image = global::MediaBazaarApp.Properties.Resources.round_person_add_black_48dp;
            this.manageEmpPic.Location = new System.Drawing.Point(12, 11);
            this.manageEmpPic.Name = "manageEmpPic";
            this.manageEmpPic.Size = new System.Drawing.Size(56, 57);
            this.manageEmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageEmpPic.TabIndex = 0;
            this.manageEmpPic.TabStop = false;
            this.manageEmpPic.Click += new System.EventHandler(this.ManageEmpPic_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MediaBazaarApp.Properties.Resources.MediaBazaarLogo;
            this.pictureBox7.Location = new System.Drawing.Point(6, 501);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 191);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTime.Location = new System.Drawing.Point(38, 323);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(120, 54);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "12:30";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDayOfWeek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(38, 383);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(278, 54);
            this.lbDateDayOfWeek.TabIndex = 8;
            this.lbDateDayOfWeek.Text = "Monday, 1 Jan";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetingMsg.Location = new System.Drawing.Point(36, 248);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(533, 65);
            this.lbGreetingMsg.TabIndex = 5;
            this.lbGreetingMsg.Text = "Good morning, Name!";
            // 
            // tabControlAdministration
            // 
            this.tabControlAdministration.Controls.Add(this.HomeTab);
            this.tabControlAdministration.Controls.Add(this.EmployeesTab);
            this.tabControlAdministration.Controls.Add(this.SchedulingTab);
            this.tabControlAdministration.Controls.Add(this.StocksTab);
            this.tabControlAdministration.Controls.Add(this.ManageDepartmentsTab);
            this.tabControlAdministration.Controls.Add(this.tabPageEditAccountRequests);
            this.tabControlAdministration.Controls.Add(this.settingsTab);
            this.tabControlAdministration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdministration.Location = new System.Drawing.Point(-3, -2);
            this.tabControlAdministration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlAdministration.Multiline = true;
            this.tabControlAdministration.Name = "tabControlAdministration";
            this.tabControlAdministration.SelectedIndex = 0;
            this.tabControlAdministration.Size = new System.Drawing.Size(1105, 732);
            this.tabControlAdministration.TabIndex = 0;
            this.tabControlAdministration.SelectedIndexChanged += new System.EventHandler(this.tabControlAdministration_SelectedIndexChanged);
            // 
            // tabPageEditAccountRequests
            // 
            this.tabPageEditAccountRequests.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPageEditAccountRequests.Controls.Add(this.btnUnmarkSelectedEditAccountRequest);
            this.tabPageEditAccountRequests.Controls.Add(this.lbFilterEditAccountRequests);
            this.tabPageEditAccountRequests.Controls.Add(this.cbFilterEditAccountRequests);
            this.tabPageEditAccountRequests.Controls.Add(this.lbTitleEditAccountRequests);
            this.tabPageEditAccountRequests.Controls.Add(this.btnDeclineEditAccountRequest);
            this.tabPageEditAccountRequests.Controls.Add(this.btnAcceptEditAccountRequest);
            this.tabPageEditAccountRequests.Controls.Add(this.dgvEditAccountRequests);
            this.tabPageEditAccountRequests.Location = new System.Drawing.Point(4, 29);
            this.tabPageEditAccountRequests.Name = "tabPageEditAccountRequests";
            this.tabPageEditAccountRequests.Size = new System.Drawing.Size(1097, 699);
            this.tabPageEditAccountRequests.TabIndex = 9;
            this.tabPageEditAccountRequests.Text = "Edit Account requests";
            // 
            // btnUnmarkSelectedEditAccountRequest
            // 
            this.btnUnmarkSelectedEditAccountRequest.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUnmarkSelectedEditAccountRequest.Location = new System.Drawing.Point(111, 617);
            this.btnUnmarkSelectedEditAccountRequest.Name = "btnUnmarkSelectedEditAccountRequest";
            this.btnUnmarkSelectedEditAccountRequest.Size = new System.Drawing.Size(348, 53);
            this.btnUnmarkSelectedEditAccountRequest.TabIndex = 6;
            this.btnUnmarkSelectedEditAccountRequest.Text = "Unmark selected row";
            this.btnUnmarkSelectedEditAccountRequest.UseVisualStyleBackColor = false;
            this.btnUnmarkSelectedEditAccountRequest.Click += new System.EventHandler(this.btnUnmarkSelectedEditAccountRequest_Click);
            // 
            // lbFilterEditAccountRequests
            // 
            this.lbFilterEditAccountRequests.AutoSize = true;
            this.lbFilterEditAccountRequests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFilterEditAccountRequests.Location = new System.Drawing.Point(154, 159);
            this.lbFilterEditAccountRequests.Name = "lbFilterEditAccountRequests";
            this.lbFilterEditAccountRequests.Size = new System.Drawing.Size(230, 23);
            this.lbFilterEditAccountRequests.TabIndex = 5;
            this.lbFilterEditAccountRequests.Text = "Filter requests on status >>";
            // 
            // cbFilterEditAccountRequests
            // 
            this.cbFilterEditAccountRequests.FormattingEnabled = true;
            this.cbFilterEditAccountRequests.Items.AddRange(new object[] {
            "All",
            "Accepted",
            "Declined",
            "InProgress"});
            this.cbFilterEditAccountRequests.Location = new System.Drawing.Point(463, 159);
            this.cbFilterEditAccountRequests.Name = "cbFilterEditAccountRequests";
            this.cbFilterEditAccountRequests.Size = new System.Drawing.Size(354, 28);
            this.cbFilterEditAccountRequests.TabIndex = 4;
            this.cbFilterEditAccountRequests.SelectedIndexChanged += new System.EventHandler(this.cbFilterEditAccountRequests_SelectedIndexChanged);
            // 
            // lbTitleEditAccountRequests
            // 
            this.lbTitleEditAccountRequests.AutoSize = true;
            this.lbTitleEditAccountRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitleEditAccountRequests.Location = new System.Drawing.Point(298, 48);
            this.lbTitleEditAccountRequests.Name = "lbTitleEditAccountRequests";
            this.lbTitleEditAccountRequests.Size = new System.Drawing.Size(391, 28);
            this.lbTitleEditAccountRequests.TabIndex = 3;
            this.lbTitleEditAccountRequests.Text = "Requests for edit account by employees";
            // 
            // btnDeclineEditAccountRequest
            // 
            this.btnDeclineEditAccountRequest.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeclineEditAccountRequest.Location = new System.Drawing.Point(769, 617);
            this.btnDeclineEditAccountRequest.Name = "btnDeclineEditAccountRequest";
            this.btnDeclineEditAccountRequest.Size = new System.Drawing.Size(159, 53);
            this.btnDeclineEditAccountRequest.TabIndex = 2;
            this.btnDeclineEditAccountRequest.Text = "Decline";
            this.btnDeclineEditAccountRequest.UseVisualStyleBackColor = false;
            this.btnDeclineEditAccountRequest.Click += new System.EventHandler(this.btnDeclineEditAccountRequest_Click);
            // 
            // btnAcceptEditAccountRequest
            // 
            this.btnAcceptEditAccountRequest.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAcceptEditAccountRequest.Location = new System.Drawing.Point(604, 617);
            this.btnAcceptEditAccountRequest.Name = "btnAcceptEditAccountRequest";
            this.btnAcceptEditAccountRequest.Size = new System.Drawing.Size(159, 53);
            this.btnAcceptEditAccountRequest.TabIndex = 1;
            this.btnAcceptEditAccountRequest.Text = "Accept";
            this.btnAcceptEditAccountRequest.UseVisualStyleBackColor = false;
            this.btnAcceptEditAccountRequest.Click += new System.EventHandler(this.btnAcceptEditAccountRequest_Click);
            // 
            // dgvEditAccountRequests
            // 
            this.dgvEditAccountRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditAccountRequests.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEditAccountRequests.ColumnHeadersHeight = 29;
            this.dgvEditAccountRequests.Location = new System.Drawing.Point(46, 229);
            this.dgvEditAccountRequests.Name = "dgvEditAccountRequests";
            this.dgvEditAccountRequests.RowHeadersWidth = 62;
            this.dgvEditAccountRequests.RowTemplate.Height = 28;
            this.dgvEditAccountRequests.Size = new System.Drawing.Size(961, 368);
            this.dgvEditAccountRequests.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.settingsTab.Controls.Add(this.applyShortcutsBTN);
            this.settingsTab.Controls.Add(this.manageAttendanceCH);
            this.settingsTab.Controls.Add(this.manageStockCH);
            this.settingsTab.Controls.Add(this.manageDepCH);
            this.settingsTab.Controls.Add(this.weeklyScheduleCH);
            this.settingsTab.Controls.Add(this.holidayLeaveReqCH);
            this.settingsTab.Controls.Add(this.manageEmpCH);
            this.settingsTab.Location = new System.Drawing.Point(4, 29);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1097, 699);
            this.settingsTab.TabIndex = 8;
            this.settingsTab.Text = "Settings";
            // 
            // applyShortcutsBTN
            // 
            this.applyShortcutsBTN.Location = new System.Drawing.Point(526, 208);
            this.applyShortcutsBTN.Name = "applyShortcutsBTN";
            this.applyShortcutsBTN.Size = new System.Drawing.Size(109, 48);
            this.applyShortcutsBTN.TabIndex = 12;
            this.applyShortcutsBTN.Text = "Apply ";
            this.applyShortcutsBTN.UseVisualStyleBackColor = true;
            this.applyShortcutsBTN.Click += new System.EventHandler(this.ApplyShortcutsBTN_Click);
            // 
            // manageAttendanceCH
            // 
            this.manageAttendanceCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageAttendanceCH.Location = new System.Drawing.Point(169, 234);
            this.manageAttendanceCH.Name = "manageAttendanceCH";
            this.manageAttendanceCH.Size = new System.Drawing.Size(256, 66);
            this.manageAttendanceCH.TabIndex = 11;
            this.manageAttendanceCH.Text = "Manage attendance shortcut";
            this.manageAttendanceCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageAttendanceCH.UseVisualStyleBackColor = true;
            this.manageAttendanceCH.CheckedChanged += new System.EventHandler(this.manageAttendanceCH_CheckedChanged);
            // 
            // manageStockCH
            // 
            this.manageStockCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageStockCH.Location = new System.Drawing.Point(169, 306);
            this.manageStockCH.Name = "manageStockCH";
            this.manageStockCH.Size = new System.Drawing.Size(256, 66);
            this.manageStockCH.TabIndex = 10;
            this.manageStockCH.Text = "Manage stock shortcut";
            this.manageStockCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageStockCH.UseVisualStyleBackColor = true;
            this.manageStockCH.CheckedChanged += new System.EventHandler(this.manageStockCH_CheckedChanged);
            // 
            // manageDepCH
            // 
            this.manageDepCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageDepCH.Location = new System.Drawing.Point(169, 378);
            this.manageDepCH.Name = "manageDepCH";
            this.manageDepCH.Size = new System.Drawing.Size(256, 66);
            this.manageDepCH.TabIndex = 9;
            this.manageDepCH.Text = "Manage departments shortcut";
            this.manageDepCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageDepCH.UseVisualStyleBackColor = true;
            this.manageDepCH.CheckedChanged += new System.EventHandler(this.manageDepCH_CheckedChanged);
            // 
            // weeklyScheduleCH
            // 
            this.weeklyScheduleCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.weeklyScheduleCH.Location = new System.Drawing.Point(169, 84);
            this.weeklyScheduleCH.Name = "weeklyScheduleCH";
            this.weeklyScheduleCH.Size = new System.Drawing.Size(256, 66);
            this.weeklyScheduleCH.TabIndex = 8;
            this.weeklyScheduleCH.Text = "Weekly schedule shortcut";
            this.weeklyScheduleCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.weeklyScheduleCH.UseVisualStyleBackColor = true;
            this.weeklyScheduleCH.CheckedChanged += new System.EventHandler(this.weeklyScheduleCH_CheckedChanged);
            // 
            // holidayLeaveReqCH
            // 
            this.holidayLeaveReqCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.holidayLeaveReqCH.Location = new System.Drawing.Point(169, 156);
            this.holidayLeaveReqCH.Name = "holidayLeaveReqCH";
            this.holidayLeaveReqCH.Size = new System.Drawing.Size(256, 72);
            this.holidayLeaveReqCH.TabIndex = 7;
            this.holidayLeaveReqCH.Text = "Holiday leave shortcut";
            this.holidayLeaveReqCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.holidayLeaveReqCH.UseVisualStyleBackColor = true;
            this.holidayLeaveReqCH.CheckedChanged += new System.EventHandler(this.holidayLeaveReqCH_CheckedChanged);
            // 
            // manageEmpCH
            // 
            this.manageEmpCH.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageEmpCH.Location = new System.Drawing.Point(169, 6);
            this.manageEmpCH.Name = "manageEmpCH";
            this.manageEmpCH.Size = new System.Drawing.Size(256, 72);
            this.manageEmpCH.TabIndex = 6;
            this.manageEmpCH.Text = "Manage employees shortcut";
            this.manageEmpCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageEmpCH.UseVisualStyleBackColor = true;
            this.manageEmpCH.CheckedChanged += new System.EventHandler(this.manageEmpCH_CheckedChanged);
            // 
            // lbHLRDays
            // 
            this.lbHLRDays.AutoSize = true;
            this.lbHLRDays.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHLRDays.Location = new System.Drawing.Point(261, 457);
            this.lbHLRDays.Name = "lbHLRDays";
            this.lbHLRDays.Size = new System.Drawing.Size(130, 20);
            this.lbHLRDays.TabIndex = 83;
            this.lbHLRDays.Text = "Holiday leave days";
            // 
            // tbxHLRDays
            // 
            this.tbxHLRDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxHLRDays.Location = new System.Drawing.Point(265, 488);
            this.tbxHLRDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHLRDays.Name = "tbxHLRDays";
            this.tbxHLRDays.Size = new System.Drawing.Size(168, 27);
            this.tbxHLRDays.TabIndex = 84;
            this.tbxHLRDays.Text = "0";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1114, 743);
            this.Controls.Add(this.tabControlAdministration);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministrationForm_FormClosed);
            this.ManageDepartmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.gbxSearchDep.ResumeLayout(false);
            this.gbxSearchDep.PerformLayout();
            this.gbxEditDepartment.ResumeLayout(false);
            this.gbxEditDepartment.PerformLayout();
            this.gbxCreateDeparmtent.ResumeLayout(false);
            this.gbxCreateDeparmtent.PerformLayout();
            this.StocksTab.ResumeLayout(false);
            this.tabControlStocks.ResumeLayout(false);
            this.AddStocksTab.ResumeLayout(false);
            this.AddStocksTab.PerformLayout();
            this.ManageStocksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.gbxSearchStock.ResumeLayout(false);
            this.gbxSearchStock.PerformLayout();
            this.SchedulingTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbWeeklySchedule.ResumeLayout(false);
            this.tbWeeklySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.tpCreateSchedule.ResumeLayout(false);
            this.gbAutoSch.ResumeLayout(false);
            this.gbAutoSch.PerformLayout();
            this.gbAssignShiftManually.ResumeLayout(false);
            this.gbAssignShiftManually.PerformLayout();
            this.tpManageAttendance.ResumeLayout(false);
            this.tpManageAttendance.PerformLayout();
            this.EmployeesTab.ResumeLayout(false);
            this.tabControlEmployees.ResumeLayout(false);
            this.AddEmpTab.ResumeLayout(false);
            this.AddEmpTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpHourlyWages)).EndInit();
            this.ManageEmpTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbxShowEmp.ResumeLayout(false);
            this.gbxSearchEmp.ResumeLayout(false);
            this.gbxSearchEmp.PerformLayout();
            this.EmpExpiredContractTab.ResumeLayout(false);
            this.gbxEmpRenewContract.ResumeLayout(false);
            this.gbxEmpRenewContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesExpiredContract)).EndInit();
            this.HolidayRequestsTab.ResumeLayout(false);
            this.HolidayRequestsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHLR)).EndInit();
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.panelEmpExpiredContract.ResumeLayout(false);
            this.panelEmpExpiredContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmpExpiredContract)).EndInit();
            this.panelHLRNotifications.ResumeLayout(false);
            this.panelHLRNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHLRNotifications)).EndInit();
            this.manageDepartmentsShortcut.ResumeLayout(false);
            this.manageDepartmentsShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDepPic)).EndInit();
            this.manageStockShortcut.ResumeLayout(false);
            this.manageStockShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageStockPic)).EndInit();
            this.manageAttendanceShortcut.ResumeLayout(false);
            this.manageAttendanceShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageAttendancePic)).EndInit();
            this.weeklySchedukeShortcut.ResumeLayout(false);
            this.weeklySchedukeShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekSchedulePic)).EndInit();
            this.holidayLeaveRequestsShortcut.ResumeLayout(false);
            this.holidayLeaveRequestsShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidayLeavePic)).EndInit();
            this.manageEmpShortcut.ResumeLayout(false);
            this.manageEmpShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmpPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabControlAdministration.ResumeLayout(false);
            this.tabPageEditAccountRequests.ResumeLayout(false);
            this.tabPageEditAccountRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAccountRequests)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage ManageDepartmentsTab;
        private System.Windows.Forms.GroupBox gbxSearchDep;
        private System.Windows.Forms.Button btnShowAllDep;
        private System.Windows.Forms.TextBox tbxSearchDep;
        private System.Windows.Forms.GroupBox gbxEditDepartment;
        private System.Windows.Forms.Label lbDepartmentCurrManagerEdit;
        private System.Windows.Forms.Label lbDepartmentEditInfo;
        private System.Windows.Forms.Button btnApplyChangesDepartment;
        private System.Windows.Forms.ComboBox cbDepartmentManagerEdit;
        private System.Windows.Forms.Label lbDepartmentManagerEdit;
        private System.Windows.Forms.TextBox tbxDepartmentNameEdit;
        private System.Windows.Forms.Label lbDepartmentNameEdit;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDepartmentsClearSelected;
        private System.Windows.Forms.GroupBox gbxCreateDeparmtent;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.ComboBox cbDepartmentManager;
        private System.Windows.Forms.Label lbDepartmentManager;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label lbDepartmentName;
        private System.Windows.Forms.TabPage StocksTab;
        private System.Windows.Forms.TabControl tabControlStocks;
        private System.Windows.Forms.TabPage AddStocksTab;
        private System.Windows.Forms.Label kgLb;
        private System.Windows.Forms.Label cmLb3;
        private System.Windows.Forms.Label lbStocksMainDetails;
        private System.Windows.Forms.Label cmLb2;
        private System.Windows.Forms.Label lbStockShortDescription;
        private System.Windows.Forms.Label cmLb1;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.TextBox tbxStockWeight;
        private System.Windows.Forms.TextBox tbxStockWidth;
        private System.Windows.Forms.Label stockWeightLb;
        private System.Windows.Forms.TextBox tbxStockQuantity;
        private System.Windows.Forms.Label lbStockDimensions;
        private System.Windows.Forms.TextBox tbxStockDepth;
        private System.Windows.Forms.Label lbStockWidth;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label lbStockHeight;
        private System.Windows.Forms.TextBox tbxStockPrice;
        private System.Windows.Forms.Label lbStockBrand;
        private System.Windows.Forms.TextBox tbxStockShortDescription;
        private System.Windows.Forms.TextBox tbxStockBrand;
        private System.Windows.Forms.Label lbStockPrice;
        private System.Windows.Forms.TextBox tbxStockHeight;
        private System.Windows.Forms.Label lbStockDepth;
        private System.Windows.Forms.Label lbStockModel;
        private System.Windows.Forms.TextBox tbxStockModel;
        private System.Windows.Forms.TabPage ManageStocksTab;
        private System.Windows.Forms.Button btnShowAllStocks;
        private System.Windows.Forms.GroupBox gbxSearchStock;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.Button btnStocksClearSelected;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.TabPage SchedulingTab;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.TabControl tabControlEmployees;
        private System.Windows.Forms.TabPage AddEmpTab;
        private System.Windows.Forms.ComboBox cbEmConRelation;
        private System.Windows.Forms.Label lbEmConRelation;
        private System.Windows.Forms.TextBox tbxEmConName;
        private System.Windows.Forms.Label lbEmConName;
        private System.Windows.Forms.TextBox tbxEmConEmail;
        private System.Windows.Forms.Label lbEmConEmail;
        private System.Windows.Forms.TextBox tbxEmConPhone;
        private System.Windows.Forms.Label lbEmConPhone;
        private System.Windows.Forms.Label lbEmpEmConDetails;
        private System.Windows.Forms.Label lbEmpBsn;
        private System.Windows.Forms.TextBox tbxEmpBsn;
        private System.Windows.Forms.NumericUpDown nudEmpHourlyWages;
        private System.Windows.Forms.ComboBox cbEmpDepartment;
        private System.Windows.Forms.Label lbEmpDepartment;
        private System.Windows.Forms.ComboBox cbEmpEmploymentType;
        private System.Windows.Forms.Label lbEmpJobSpec;
        private System.Windows.Forms.Label lbEmpAddressStreet;
        private System.Windows.Forms.Label lbEmpPersonalInfo;
        private System.Windows.Forms.TextBox tbxEmpAddressStreet;
        private System.Windows.Forms.TextBox tbxEmpAddressCity;
        private System.Windows.Forms.ComboBox cbEmpGender;
        private System.Windows.Forms.Label lbEmpAddressCity;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.TextBox tbxEmpAddressCountry;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Label lbEmpAddressPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmpAddressCountry;
        private System.Windows.Forms.DateTimePicker dtpEmpDateOfBirth;
        private System.Windows.Forms.TextBox tbxEmpAddressPostCode;
        private System.Windows.Forms.Button btnAddEmpoyee;
        private System.Windows.Forms.Label lbEmpEmployementType;
        private System.Windows.Forms.Label lbEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpHourlyWages;
        private System.Windows.Forms.TextBox tbxEmpPhone;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.TextBox tbxEmpLname;
        private System.Windows.Forms.Label lbEmpLname;
        private System.Windows.Forms.TextBox tbxEmpFname;
        private System.Windows.Forms.Label lbEmpFname;
        private System.Windows.Forms.TabPage ManageEmpTab;
        private System.Windows.Forms.GroupBox gbxShowEmp;
        private System.Windows.Forms.ComboBox cbSelectEmpDepartment;
        private System.Windows.Forms.GroupBox gbxSearchEmp;
        private System.Windows.Forms.TextBox tbxSearchEmp;
        private System.Windows.Forms.Button btnClearSelectedEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Panel panelHLRNotifications;
        private System.Windows.Forms.Label lbHLRNotifications;
        private System.Windows.Forms.PictureBox pbxHLRNotifications;
        private System.Windows.Forms.Panel manageDepartmentsShortcut;
        private System.Windows.Forms.Label manageDepLBL;
        private System.Windows.Forms.PictureBox manageDepPic;
        private System.Windows.Forms.Panel manageStockShortcut;
        private System.Windows.Forms.Label manageStockLBL;
        private System.Windows.Forms.PictureBox manageStockPic;
        private System.Windows.Forms.Panel manageAttendanceShortcut;
        private System.Windows.Forms.Label manageAttendanceLBL;
        private System.Windows.Forms.PictureBox manageAttendancePic;
        private System.Windows.Forms.Panel weeklySchedukeShortcut;
        private System.Windows.Forms.Label weeklyScheduleLBL;
        private System.Windows.Forms.PictureBox weekSchedulePic;
        private System.Windows.Forms.Panel holidayLeaveRequestsShortcut;
        private System.Windows.Forms.Label holidayLeaveLBL;
        private System.Windows.Forms.PictureBox holidayLeavePic;
        private System.Windows.Forms.Panel manageEmpShortcut;
        private System.Windows.Forms.Label manageEmpLBL;
        private System.Windows.Forms.PictureBox manageEmpPic;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.TabControl tabControlAdministration;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button applyShortcutsBTN;
        private System.Windows.Forms.CheckBox manageAttendanceCH;
        private System.Windows.Forms.CheckBox manageStockCH;
        private System.Windows.Forms.CheckBox manageDepCH;
        private System.Windows.Forms.CheckBox weeklyScheduleCH;
        private System.Windows.Forms.CheckBox holidayLeaveReqCH;
        private System.Windows.Forms.CheckBox manageEmpCH;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Label lbEmpNationality;
        private System.Windows.Forms.TextBox tbxEmpNationality;
        private System.Windows.Forms.DateTimePicker dtpEmpEndDate;
        private System.Windows.Forms.Label lbEmpEndDate;
        private System.Windows.Forms.DateTimePicker dtpEmpStartDate;
        private System.Windows.Forms.Label lbEmpStartDate;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TabPage tabPageEditAccountRequests;
        private System.Windows.Forms.Button btnDeclineEditAccountRequest;
        private System.Windows.Forms.Button btnAcceptEditAccountRequest;
        private System.Windows.Forms.DataGridView dgvEditAccountRequests;
        private System.Windows.Forms.Label lbTitleEditAccountRequests;
        private System.Windows.Forms.Label lbFilterEditAccountRequests;
        private System.Windows.Forms.ComboBox cbFilterEditAccountRequests;
        private System.Windows.Forms.Button btnUnmarkSelectedEditAccountRequest;
        private System.Windows.Forms.CheckBox cbxEmpIndefiniteContract;
        private System.Windows.Forms.TabPage HolidayRequestsTab;
        private System.Windows.Forms.ComboBox cbFilterHLR;
        private System.Windows.Forms.DataGridView dgvHLR;
        private System.Windows.Forms.Button btnHolidayRequestsClearSelected;
        private System.Windows.Forms.Button btnHolidayRequestsDecline;
        private System.Windows.Forms.Button btnHolidayRequestsAccept;
        private System.Windows.Forms.Label lblHLRstatus;
        private System.Windows.Forms.Label lbHLR;
        private System.Windows.Forms.TabPage EmpExpiredContractTab;
        private System.Windows.Forms.Button btnEmpRenewContract;
        private System.Windows.Forms.DataGridView dgvEmployeesExpiredContract;
        private System.Windows.Forms.Button btnEmpExpiredContractUnmarkSelected;
        private System.Windows.Forms.GroupBox gbxEmpRenewContract;
        private System.Windows.Forms.Label lbNamesEmpRenewContract;
        private System.Windows.Forms.Button btnEmpSubmitChangesNewContract;
        private System.Windows.Forms.CheckBox cbxEmpMakeNewContractIndefinite;
        private System.Windows.Forms.DateTimePicker dtpEndDateNewContract;
        private System.Windows.Forms.Label lbEmpEndDateNewContract;
        private System.Windows.Forms.DateTimePicker dtpEmpStartDateNewContract;
        private System.Windows.Forms.Label lbEmpStartDateNewContract;
        private System.Windows.Forms.Label lbEmpIdRenewContract;
        private System.Windows.Forms.Panel panelEmpExpiredContract;
        private System.Windows.Forms.Label lbEmpExpiredContract;
        private System.Windows.Forms.PictureBox pbxEmpExpiredContract;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbWeeklySchedule;
        private System.Windows.Forms.Button btnRemShift;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lbWeekNumber;
        private System.Windows.Forms.ComboBox cbWeekNumber;
        private System.Windows.Forms.TabPage tpCreateSchedule;
        private System.Windows.Forms.GroupBox gbAutoSch;
        private System.Windows.Forms.Label lbWeekNrAS;
        private System.Windows.Forms.Button btnGenAS;
        private System.Windows.Forms.ComboBox cbWeekAS;
        private System.Windows.Forms.Button btnGoBackAuto;
        private System.Windows.Forms.Button btnAutoShifts;
        private System.Windows.Forms.Button btnManShifts;
        private System.Windows.Forms.GroupBox gbAssignShiftManually;
        private System.Windows.Forms.Button btnGoBackManual;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.CheckBox cbWFH;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Label lbEmpInfo;
        private System.Windows.Forms.Label lbWFH;
        private System.Windows.Forms.ComboBox cbEmps;
        private System.Windows.Forms.ComboBox cbDeps;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lbShiftType;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Label lbShiftDate;
        private System.Windows.Forms.ComboBox cbShiftType;
        private System.Windows.Forms.TabPage tpManageAttendance;
        private System.Windows.Forms.Button btnApplyAttendanceChanges;
        private System.Windows.Forms.TextBox tbReasonForAbsence;
        private System.Windows.Forms.CheckBox cbHasAttended;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Label lbHasAttended;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.ComboBox cbEmployeesShifts;
        private System.Windows.Forms.Label lbSelectedEmp;
        private System.Windows.Forms.Label lbSelectedDep;
        private System.Windows.Forms.ComboBox cbSelectedEmp;
        private System.Windows.Forms.ComboBox cbAllDeps;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWFH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedBy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAttended;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSR;
        private System.Windows.Forms.CheckBox cbFilterAttended;
        private System.Windows.Forms.CheckBox cbFilterWFH;
        private System.Windows.Forms.Label lbASHinfo;
        private System.Windows.Forms.Label lbHLRDays;
        private System.Windows.Forms.TextBox tbxHLRDays;
    }
}
