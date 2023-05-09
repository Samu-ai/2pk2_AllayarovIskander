using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class OOO : Company
    {
        public string Founder { get; set; }

        public OOO(string name, int okpo, DateTime date, string founder) : base(name, okpo, date)
        {
            Founder = founder;
        }
        public override void GetCompanyInfo()
        {
            base.GetCompanyInfo();
            Console.WriteLine($"Учредитель - {Founder}");
        }
    }
}
