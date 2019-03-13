using System;
using System.Collections.Generic;
using HPlusSports.Models;
using HPlusSports.Services;
using Xamarin.Forms;

namespace HPlusSports
{
    public partial class OrderForm : TabbedPage
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var order = BindingContext as Order;
            DisplayAlert("order placed", $"{order.ProductName} of {order.Quantity}", "ok");
        }
    }
}
