using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "microsoft";
        job1._sYear = 2016;
        job1._eYear = 2018;
        Job job2 = new Job();
        job2._jobTitle = "Data analyst";
        job2._company = "apple";
        job2._sYear = 2018;
        job2._eYear = 2022;
    }
}