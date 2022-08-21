﻿using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Presenters;
using contact_manager.Views;

namespace contact_manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var dashboardView = new DashboardView();
            //TODO Repository mitgeben sobald implementiert
            var customerRepository = new PersonRepository<Customer>(new FilePersonStore<Customer>());
            var customerService = new CustomerService(customerRepository);
            //TODO Repository mitgeben sobald implementiert
            var employeeRepository = new PersonRepository<Employee>(new FilePersonStore<Employee>());
            var employeeService = new EmployeeService(employeeRepository);
            var dashboardPresenter = new DashboardPresenter(dashboardView, customerService, employeeService);

            Application.Run(dashboardView);
        }
    }
}
