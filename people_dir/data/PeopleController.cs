using System;
using System.Collections.Generic;
using System.Linq;

namespace people_dir.data
{

    internal class PeopleController
    {
        public List<People> PeopleList = new List<People>();

        public List<string> GroupList = new List<string>();

        public People PeopleFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(Program.path);

            foreach (string line in lines)
            {
                var data = line.Split(' ');

                int id_people = Convert.ToInt32(data[People.ID]);
                string name_people = data[People.NAME];
                string surname_people = data[People.SURNAME];
                DateTime date_of_birth = DateTime.Parse(data[People.DATE_OF_BIRTH]);
                string t_number_people = data[People.T_NUMBER];
                string e_mail_people = data[People.EMAIL];
                string group_people_name = data[People.GROUP_NAME];


                if (!GroupList.Contains(group_people_name))
                    GroupList.Add(group_people_name);

                PeopleList.Add(new People(id_people, name_people, surname_people, date_of_birth, t_number_people, e_mail_people, group_people_name));

            }
            return new People();
        }

        public List<string> retrieveGroupList()
        {
            List<string> result = new List<string>();
            foreach (string s in GroupList)
            {
                result.Add(s);
            }
            return result;
        }

        public List<People> retrievePeopleList()
        {
            List<People> result = new List<People>();

            foreach (var s in PeopleList)
            {
                result.Add(new People(s.id_people, s.name_people, s.surname_people, s.date_of_birth, s.t_number_people, s.e_mail_people, s.group_people_name));

            }
            return result;
        }
    }

   
}
