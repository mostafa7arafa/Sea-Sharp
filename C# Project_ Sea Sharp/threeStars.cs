using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOneMostafaArafa
{
    class threeStars:Fleet
    {
        public threeStars(string name)
            : base(name) { }
        public override string getCost()
        {
            return string.Format("{0:c}", 780);
        }
    }
}
