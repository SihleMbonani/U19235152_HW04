using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_HW04.Models
{
    public class Influencers: NPOmember
    {
        private string image;
        private string universityName;
        private string countryName;
        private int followers;

        public int Followers { get => followers; set => followers = value; }
        
        
        public string UniversityName { get => universityName; set => universityName = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public string Image { get => image; set => image = value; }

        public Influencers(int npoId, string fName, string lName, string universityName, string countName, int followers, string InfImage):base(npoId,fName,lName)
        {
            UniversityName = universityName;
            CountryName = countName;
            Followers = followers;
            Image = InfImage;
            
            
        }

        public override string GetProfile()
        {
            return base.GetProfile();
        }

        public override string Description()
        {
            throw new NotImplementedException();
        }
    }
}