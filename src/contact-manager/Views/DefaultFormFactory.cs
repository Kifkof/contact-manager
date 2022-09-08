﻿using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Presenters;
using contact_manager.Presenters.Authentication;
using contact_manager.Views.Authentication;

namespace contact_manager.Views
{
    internal class DefaultFormFactory : IFormFactory
    {
        public LoginView CreateLoginDialog()
        {
            var loginView = new LoginView();
            var userService = new UserService();
            var loginPresenter = new LoginPresenter(loginView, userService, this);
            loginPresenter.Init();

            return loginView;
        }

        public OverviewView CreateOverview(User user)
        {
            var overviewView = new OverviewView();
            var customerRepository = new Repository<Customer>(new FileStore<Customer>());
            var customerService = new CustomerService(customerRepository);
            var employeeRepository = new Repository<Employee>(new FileStore<Employee>());
            var employeeService = new EmployeeService(employeeRepository);
            var customerNoteRepository = new Repository<CustomerNote>(new FileStore<CustomerNote>());
            var customerNotesService = new CustomerNoteService(customerNoteRepository);

            var overviewPresenter = new OverviewPresenter(overviewView, customerService, customerNotesService, employeeService, user);
            overviewPresenter.Init();
            overviewPresenter.LoadAllCustomers();

            return overviewView;
        }
    }
}
