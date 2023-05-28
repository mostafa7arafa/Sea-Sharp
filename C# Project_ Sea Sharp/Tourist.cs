using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOneMostafaArafa
{
    class Tourist : Form1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Nation { get; set; }
        public int getAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
        public Tourist (string Fn, string Ln, string G, DateTime bth ,string N)
        {
            FirstName = Fn;
            LastName = Ln;
            Gender = G;
            Age = getAge(bth);
            Nation = N;
        }
    }
}
