using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using INF272_HW04.Models;



//we want to create a bridge or an interface in order to link the volunteer class with the volunteer "database"
namespace INF272_HW04.VolunteersDB
{
    public interface VolunteerInterface // Because we are working with an interface it is set as "interface"
    {
        List<VolunteerVM> ChooseAllVolunteers();

        VolunteerVM SelectVolunteerByID(int id);

        void InsertVol(VolunteerVM vol);

        void UpdateVol(VolunteerVM stud);

        void DeleteVol(int id, VolunteerVM vol);

    }
}