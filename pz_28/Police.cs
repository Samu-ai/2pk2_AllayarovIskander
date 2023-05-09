using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Police
    {
        public void Opoveshenie()
        {
            Console.WriteLine("Снизьте скорость");
        }
        public void Zaderzhanie()
        {
            Console.WriteLine("Начинаю задержание");
        }
        public void Smert()
        {
            Console.WriteLine("Упс, вы перевернулись");
        }
    }
}
