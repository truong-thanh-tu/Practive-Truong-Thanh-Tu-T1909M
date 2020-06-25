using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive.ThiThucHanh
{
    class Run
    {
        Book[] blist = {
            new Book(01,"Tuoi Tre Dang Gia Bao Nhieu",18000,"Nguyen"),
            new Book(02,"Kheo an kheo noi co duoc thien ha",28000,"Tung"),
            new Book(03,"Luat tri nao",38000,"Hoan")
        };
        Mobile[] Mlist =
        {
            new Mobile(01,"ABC",1200,"CBA"),
            new Mobile(02,"BCA",2000,"ABC"),
            new Mobile(03,"DCH",2154,"YHD")
        };

        public void ShowBook()
        {
            foreach(Book b in blist)
            {
                b.ComputeTax(8/10);
                b.Show();
            }
        }
        public void ShowMobile()
        {
            foreach (Mobile m in Mlist)
            {
                m.ComputeTax(8 / 10);
                m.Show();
            }
        }
        public static void Display()
        {
            Run r = new Run();
            r.ShowBook();
            r.ShowMobile();
        }
    }
}
