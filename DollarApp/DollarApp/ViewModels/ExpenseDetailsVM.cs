using System;
using System.Collections.Generic;
using System.Text;
using DollarApp.Models;
using System.ComponentModel;

namespace DollarApp.ViewModels
{
    public class ExpenseDetailsVM : INotifyPropertyChanged
    {
        private Expense expense;
        public Expense Expense
        {
            get { return expense; }
            set
            {
                expense = value;
                OnPropertyChanged("Expense");
            }
        }
        public ExpenseDetailsVM() { }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
