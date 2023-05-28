using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOneMostafaArafa
{
    class fourStars : Fleet
    {
        public fourStars(string name)
            : base(name) { }
        public override string getCost()
        {
            return string.Format("{0:c}", 1170);
        }
    }
}
