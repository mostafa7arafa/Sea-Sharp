using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOneMostafaArafa
{
    abstract class Fleet : Form1
    {
        public string Name { get; set; }
        public Fleet (string name)
        {
            Name = name;
        }
        public abstract string getCost();
    }
}
