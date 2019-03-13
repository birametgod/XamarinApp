using System;
using System.ComponentModel;

namespace HPlusSports.Models
{
    public class Product : INotifyPropertyChanged
    {
        private string namePrivate; 

        public string Name
		{
            get { return namePrivate; }
            set
            {
                if (value != namePrivate)
                {
                    namePrivate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        private int idPrivate;

        public int Id
		{
            get { return idPrivate; }
            set
            {
                if (value != idPrivate)
                {
                    idPrivate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
                }
            }
        }

        private string dscription;

        public string Description
		{
			get { return dscription; }
            set
            {
                if (value != dscription)
                {
                    dscription = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }

        private string imageTitle;

        public string Image_Title
		{
            get { return imageTitle; }
            set
            {
                if (value != imageTitle)
                {
                    imageTitle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Image_Title"));
                }
            }
        }

        private string imagePrivate;


        public string Image
		{
            get { return imagePrivate; }
            set
            {
                if (value != imagePrivate)
                {
                    imagePrivate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Image"));
                }
            }
        }

        public Uri ImageUri
        {
            get
            {
                return String.IsNullOrEmpty(Image) ? null : new Uri(Image);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
