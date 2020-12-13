using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        static void Main(string[] args)
        {
            Entry entry1 = new Entry("Jimmy", "Chuong");
            entry1.Address = "Portcullis House";
            entry1.Email = "veryimportantperson@hotmail.co.uk";
            entry1.Phone = 07264742776;
            Console.WriteLine(entry1.GetAll());

            Console.ReadKey();
        }
    }
}
