using System;
using System.Collections.Generic;
using System.Text;

namespace CarsambaSabahSiniflar
{
    public class Product
    {
        private string MName;
        private float MPrice;
        private string MUrl;

        public string ImageUrl
        {
            get { return MUrl; }
            set { MUrl = value; }
        }
        public string Name
        {
            get { return MName; }
            set {
                if (NameChange != null)
                {
                 MName = value;
                 NameChange();
                }
            }
        }
        public float Price
        {
            get { return MPrice; }
            set { MPrice = value; }
        }

        public Product( string AD, string URL, float fiyat) 
        {
            this.Name = AD;
            this.ImageUrl = URL;
            this.Price = fiyat;
        }
        public Product()
        { }

        public string GetHTML()
        {
            string htmlstring="";
            htmlstring = "<h1>" + this.Name + "</h1>";
            htmlstring += "<h2> FÝYATI :" + this.Price.ToString() + "</h2>";
            htmlstring += "<img src=" + this.ImageUrl + ">";

            return htmlstring;
        }

        public delegate void NameChangeHandler();

        public event NameChangeHandler NameChange;



    }
}
