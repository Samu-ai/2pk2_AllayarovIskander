using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    public interface ICLoneable
    {
        object Clone();
    }
    internal class Company : ICLoneable
    {
        private DateTime _date;
        private int _okpo;
        static int count_obj = 0;
        static int count_obj_after = 0;
        public string Name { get; set; } = "CompanyName";
        public int Okpo
        {
            get { return _okpo; }
            set
            {
                if (8 <= Convert.ToString(value).Length && Convert.ToString(value).Length < 9)
                {
                    _okpo = value;
                }
                else
                {
                    Console.WriteLine("неверное окпо");
                }
            }
        }
        public DateTime DateOfRegistry
        {
            get { return _date; }
            set
            {
                if (value.CompareTo(new DateTime(1990, 1, 1, 0, 0, 0)) > 0 && value.CompareTo(new DateTime(2022, 1, 1, 0, 0, 0)) < 0)
                {
                    if (2020 < value.Year)
                    {
                        count_obj += 1;
                        count_obj_after += 1;
                        _date = value;
                    }
                    count_obj += 1;
                    _date = value;
                }
                else
                {
                    Console.WriteLine("неверная дата");
                }
            }
        }
        public Company(string name, int okpo, DateTime date)
        {
            Name = name;
            Okpo = okpo;
            DateOfRegistry = date;
            count_obj += 1;
        }

        public virtual void GetCompanyInfo()
        {
            Console.WriteLine($"Название - {Name}\nДата регистрации = {DateOfRegistry}\nОкпо - {Okpo}");
        }
        public void CountCompanies()
        {
            Console.WriteLine($"Всего - {count_obj}\nПосле 2020 = {count_obj_after}");
        }
        public object Clone()
        {
            return new Company(Name, Okpo, DateOfRegistry);
        }
    }
}
