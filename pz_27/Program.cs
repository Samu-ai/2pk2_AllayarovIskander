using System.IO;

namespace pz_27
{
    internal class Program
    {
        struct TRAIN
        {
            public string NAZN;
            public int NUMR;
            public TimeOnly TIME;

            TRAIN(string nazn, int numr, TimeOnly time)
            {
                NAZN = nazn;
                NUMR = numr;
                TIME = time;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}