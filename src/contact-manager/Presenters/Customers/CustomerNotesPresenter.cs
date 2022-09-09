﻿using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Views.Customers.CustomerNotes;

namespace contact_manager.Presenters.Customers
{
    public class CustomerNotesPresenter : IPresenter
    {
        private readonly ICustomerNotesView _dialog;
        private readonly ICustomerNoteService _customerNoteService;
        private readonly long _customerId;
        private readonly User _user;

        public CustomerNotesPresenter(ICustomerNotesView dialog, ICustomerNoteService customerNoteService, long customerId, User user)
        {
            this._dialog = dialog;
            this._customerNoteService = customerNoteService;
            this._customerId = customerId;
            this._user = user;
        }

        public void Init()
        {
            this._dialog.SetPresenter(this);
            this.LoadAllCustomerNotes();
        }

        public void AddNewNoteFromText()
        {
            if (string.IsNullOrEmpty(this._dialog.NewNoteText))
                return;

            this._customerNoteService.CreateNewNote(this._customerId, this._dialog.NewNoteText, this._user.UserName);
            this._dialog.NewNoteText = string.Empty;
            this.LoadAllCustomerNotes();
        }

        public void LoadAllCustomerNotes()
        {
            this._dialog.ClearAllNotes();
            var notes = this._customerNoteService.LoadAllNotesByCustomerId(this._customerId);
            foreach (var customerNote in notes.OrderByDescending(n => n.CreatedAt))
            {
                this._dialog.AddNewNoteToHistory(customerNote);
            }
        }
    }
}
