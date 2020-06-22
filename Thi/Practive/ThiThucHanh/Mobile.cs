using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive.ThiThucHanh
{
    class Mobile:Product
    {
        public Mobile(int id, string name, double price, string producert) : base(id, name, price, producert)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Producert = producert;
        }
        public override double ComputeTax(float x)
        {
            return this.Price = this.Price * x;
        }
        public override void Show()
        {
            Console.WriteLine("ID: {0}", this.ID);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Price: {0}", this.Price);
            Console.WriteLine("Producet: {0}", this.Producert);

        }
    }
}
