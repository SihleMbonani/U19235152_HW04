using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_HW04.Models
{
    public class Group: NPOmember
    {
        private int gMember;

        public int GMember { get => gMember; set => gMember = value; }

        public Group (int npoId, string fName, string lName, int groupMember) : base(npoId, fName, lName)
        {
            gMember = groupMember;
        }

        public override string GetProfile()
        {
            return base.GetProfile();
        }

        public override string Description()
        {
            return "Having a strong image is key for a nonprofit to succeed! Most nonprofits do notunderstand the correct steps towards developing a strong image.";
        }
    }
}