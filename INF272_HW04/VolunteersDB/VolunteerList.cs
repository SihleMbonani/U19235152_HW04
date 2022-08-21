using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_HW04.VolunteersDB
{
    public class VolunteerList
    {
        private static readonly List<Models.VolunteerVM> volunteerList = null;

        static VolunteerList()
        {
            volunteerList = new List<Models.VolunteerVM>()
            {
                new Models.VolunteerVM()
                {
                    ID = 1,
                    Name = "Preferred Name",
                    Surname = "Surname",
                    Age = 0,
                    Province = "Province",
                }
            };
        }

        //So we can return the existing list
        public static List<Models.VolunteerVM> ChooseVolunteerList()
        {
            return volunteerList;
        }

       
        //CRUD
        //Now we want to create the list of volunteer
       

        public static void InsertList(Models.VolunteerVM vol)
        {
            volunteerList.Add(vol);
        }


        //Now we want to Update the list
        public static void UpdateList(Models.VolunteerVM vol)
        {
            Models.VolunteerVM vUpdate = volunteerList.Find(x => x.ID == vol.ID);
            vUpdate.Name = vol.Name;
            vUpdate.Surname = vol.Surname;
            vUpdate.Age = vol.Age;
            vUpdate.Province = vol.Province;
        }


        //Now we eant to delete the list
        public static void DeleteList(int id) //identify by the id
        {
            Models.VolunteerVM volDelete = volunteerList.Find(x => x.ID == id);
            volunteerList.Remove(volDelete);
        }

    }
}