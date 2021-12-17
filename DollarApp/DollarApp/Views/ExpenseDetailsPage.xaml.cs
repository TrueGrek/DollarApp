using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DollarApp.Models;
using DollarApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DollarApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpenseDetailsPage : ContentPage
    {
        ExpenseDetailsVM ViewModel;
        public ExpenseDetailsPage()
        {
            InitializeComponent();
        }
        public ExpenseDetailsPage(Expense expense)
        {
            InitializeComponent();
            ViewModel = Resources["vm"] as ExpenseDetailsVM;
            ViewModel.Expense = expense;
        }
    }
}