﻿using MediaBazaarApp.Custom_exceptions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MediaBazaarApp
{
    public class Department
    {
        //Fields
        private int id;
        private string deptId;
        private string name;
        private Employee manager;
        private List<Employee> employees;

        //Properties
        public int Id
        {
            set
            {
                this.id = value;
                string firstLetters = this.Name.Substring(0, 2);
                this.deptId = $"{firstLetters}{id}";
            }
            get { return id; }
        }

        public string DeptId
        {
            get { return this.deptId; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Za-z]{2,}$");
                if (isValid)
                {
                    this.name = value;
                }
                else
                {
                    // throw exceptions here
                    throw new DepNameException(value);
                }
            }
        }

        public Employee Manager
        {
            get { return this.manager; }
            set { this.manager = value; }
        }

        //Constructors
        public Department(string name)
        {

            this.Name = name;
            employees = new List<Employee>();
            //this.Id = id;

            //string firstLetters = this.name.Substring(0, 2);
            //dept id
            //deptId = $"{firstLetters}{id}";

            //static id
            //id++;
        }
        public Department(string name, Employee manager)
        {

            this.Name = name;
            this.Manager = manager;
            employees = new List<Employee>();
            //this.Id = id;

            //string firstLetters = this.name.Substring(0, 2);
            //dept id
            //deptId = $"{firstLetters}{id}";

            //static id
            //id++;
        }

        //Methods
        public Employee GetEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee GetEmployeeByEmail(string email)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Email == email)
                {
                    return emp;
                }
            }
            return null;
        }

        public bool isEmpExist(string email, DepartmentManagement departmentManagement)
        {
            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (emp.Email == email)
                {
                    return true;
                }
            }
            return false;
        }


        public bool AddEmployee(DepartmentManagement departmentManagement, string firstName, string lastName, DateTime dateOfBirth, string nationality, Gender gender, string email,
            string phoneNumber, string street, string city, string country, string postcode, string bsn,
            string emConName, EmergencyContactRelation emConRelation, string emConEmail, string emConPhoneNum,
            EmploymentType employmentType, double hourlyWages, DateTime startDate, DateTime endDate, Department department)
        {

            if (!isEmpExist(email, departmentManagement))
            {
                Employee newEmp = new Employee(firstName, lastName, dateOfBirth, nationality, gender, email, phoneNumber,
                    street, city, country, postcode, bsn, emConName, emConRelation, emConEmail, emConPhoneNum,
                    employmentType, hourlyWages, startDate, endDate,department);
                employees.Add(newEmp);
                return true;
            }
            return false;
        }

        public bool RemoveEmployee(string email)
        {
            Employee currEmp = GetEmployeeByEmail(email);
            if (currEmp != null)
            {
                employees.Remove(currEmp);
                return true;
            }
            return false;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public override string ToString()
        {
            return $"DepId:{this.DeptId}; Name:{this.name}";
        }


    }
}
