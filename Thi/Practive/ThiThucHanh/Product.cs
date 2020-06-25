using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive.ThiThucHanh
{
   abstract class Product
    {
        #region Khai bao thuoc tinh
        private int id;
        private string name;
        private float price;
        private string producert;
        #endregion
        #region Khoi tao contructor
        public Product(int ID,string Name,float Price,string Producer)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Producert = Producert;
        }
        #endregion
        #region Khoi tao  method
        public int ID { set; get; }
        public string Name { set; get; }
        public float Price { set; get; }
        public string Producert { set; get; }

        public  abstract float ComputeTax(float x);
        public abstract void Show();
        #endregion
    }
}
