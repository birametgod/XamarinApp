using System;
using System.ComponentModel;

namespace HPlusSports.Models
{
    public class Order : INotifyPropertyChanged
    {
        public Order()
        {
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set
            {
                if(value != productName)
                {
                    productName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProductName"));
                }
            }
        }

        private int qty;

        public int Quantity
        {
            get { return qty; }
            set{
                if(value != qty)
                {
                    qty = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
