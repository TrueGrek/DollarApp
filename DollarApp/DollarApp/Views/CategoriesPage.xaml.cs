using DollarApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DollarApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        CategoriesVM ViewModel;
        public CategoriesPage()
        {
            InitializeComponent();
            ViewModel = Resources["vm"] as CategoriesVM;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.GetExpensesPerCategory();
        }
    }
}