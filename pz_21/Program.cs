namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company twitter = new Company("Twitter", 12345678, DateTime.Now);
            twitter.GetCompanyInfo();
        }
    }
}