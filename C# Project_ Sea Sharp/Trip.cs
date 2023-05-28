using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOneMostafaArafa
{
    class Trip : Tourist
    {
        public string Route { get; set; }
        public string Plan { get; set; }
        public string Fleet { get; set; }
        public Trip(string Fn, string Ln, string G, DateTime bth, string R, string P, string F, string N)
            :base(Fn,Ln,G,bth,N)
        {
            Route = R;
            Plan = P;
            Fleet = F;
        }
    }
}
