using System;
using System.Collections.Generic;

namespace people_dir.data
{

    internal class PeopleController
    {
        public List<People> PeopleList = new List<People>();

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

                PeopleList.Add(new People(id_people, name_people, surname_people, date_of_birth, t_number_people, e_mail_people));
            }
            return new People();
        }
    }
}
