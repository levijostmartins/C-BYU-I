using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Job
{
        public string _jobTitle = "";
        public string _company;
        public int _sYear = 0;
        public int _eYear = 0;       

        public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_sYear}-{_eYear}");
    }
  
}       
