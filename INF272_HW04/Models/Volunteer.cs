using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_HW04.Models
{
    public class Volunteer: NPOmember
    {
        private int vAge;

        

        public Volunteer(int npoId, string fName, string lName,int age) : base(npoId, fName, lName)
        {
            VAge = age;
        }

        public override string GetProfile()
        {
            return base.GetProfile();
        }

        public override string Description()
        {
            return "I am a Volunteer for the Stop Hunger Now Southern Africa";
        }

        public int VAge { get => vAge; set => vAge = value; }
    }
}