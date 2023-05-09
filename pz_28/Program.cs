namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car plohoy = new Car();
            Police horoshiy = new Police();

            plohoy.opovesh += horoshiy.Opoveshenie;
            plohoy.zader += horoshiy.Zaderzhanie;
            plohoy.umer += horoshiy.Smert;

            plohoy.Razgon();
        }
    }
}