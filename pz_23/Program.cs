﻿namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company twitter = new Company("Twitter", 12345678, DateTime.Now);
            Company youtube = new Company("Youtube", 12342678, new DateTime(2021, 1, 1, 0, 0, 0));
            twitter.GetCompanyInfo();
            youtube.GetCompanyInfo();

            youtube.CountCompanies();

            OOO company = new OOO("Youtube", 12342678, new DateTime(2021, 5, 9, 15, 1, 20), "Iskander");
            company.GetCompanyInfo();
        }
    }
}