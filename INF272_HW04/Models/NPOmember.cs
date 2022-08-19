using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_HW04.Models
{
    public abstract class NPOmember
    {
        private string firstName;
        private string lastName;

        public int ID { get; set; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //base class prop
        //read only
        public int nID
        {
            get { return ID; }
        }

        public NPOmember(int npoId, string fName, string lName)
        {
            ID = npoId;
            FirstName = fName;
            LastName = lName;
        }

        public virtual string GetProfile()
        {
            return FirstName + LastName;
        }

        public abstract string Description();
        

    }
}