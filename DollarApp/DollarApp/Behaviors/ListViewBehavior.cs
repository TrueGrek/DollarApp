using DollarApp.Models;
using DollarApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DollarApp.Behaviors
{
    public class ListViewBehavior : Behavior<ListView>
    {
        ListView listView;
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            listView = bindable;
            listView.ItemSelected += ListView_ItemSelected;
        }

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Expense selectedExpense = (listView.SelectedItem) as Expense;
            Application.Current.MainPage.Navigation.PushAsync(new ExpenseDetailsPage(selectedExpense));
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            listView.ItemSelected -= ListView_ItemSelected;
        }
    }
}
