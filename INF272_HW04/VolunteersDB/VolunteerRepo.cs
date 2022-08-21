using System;
using System.Collections.Generic;


namespace INF272_HW04.VolunteersDB
{
    public class VolunteerRepo : VolunteerInterface
    {
        public List<Models.VolunteerVM> ChooseAllVolunteers()
        {
            return VolunteerList.ChooseVolunteerList();
        }


        public Models.VolunteerVM SelectVolunteerByID(int id)
        {
            return VolunteerList.ChooseVolunteerList().Find(x => x.ID == id);
        }


        public void InsertVol(Models.VolunteerVM vol)
        {
            VolunteerList.InsertList(vol);
        }


        public void UpdateVol(Models.VolunteerVM vol)
        {
            VolunteerList.UpdateList(vol);
        }


        public void DeleteVol(int id, Models.VolunteerVM stud)
        {
            VolunteerList.DeleteList(id);
        }
    }
}