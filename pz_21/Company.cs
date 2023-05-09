using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Company
    {
        public string Name { get; set; }
        public int Okpo { get; set; }
        public DateTime DateOfRegistry { get; set; }
        public Company(string name, int okpo, DateTime date)
        {
            Name = name;
            Okpo = okpo;
            DateOfRegistry = date;
        }

        public void GetCompanyInfo()
        {
            Console.WriteLine($"Название - {Name}\nДата регистрации = {DateOfRegistry}\nОкпо - {Okpo}");
        }
    }
}
