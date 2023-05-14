using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace people_dir.data
{

    internal class PeopleController
    {
        //listele care vor stoca datele persoanelor si a grupurilor (temporar)
        public List<People> PeopleList = new List<People>();

        public List<string> GroupList = new List<string>();

        //extrage datele din .txt si le adauga intr-un array de tip string
        //din string-ul dat extrage fiecare cuvant dupa id, si le stocheaza in PeopleList sau GroupList

        public People PeopleFromFile()
        {
            string[] lines = File.ReadAllLines(Program.path);

            foreach (string line in lines)
            {
                if(!string.IsNullOrWhiteSpace(line))
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
               
            }

            People.count = PeopleList.Max(t => t.id_people);
            return new People();
        }

        //returneaza lista grupurilor
        public List<string> retrieveGroupList()
        {
            List<string> result = new List<string>();
            foreach (string s in GroupList)
            {
                result.Add(s);
            }
            return result;
        }

        //returneaza lista persoanelor
        public List<People> retrievePeopleList()
        {
            List<People> result = new List<People>();

            foreach (var s in PeopleList)
            {
                result.Add(new People(s.id_people, s.name_people, s.surname_people, s.date_of_birth, s.t_number_people, s.e_mail_people, s.group_people_name));
            }
            return result;
        }

        //functia de adaugare a unei persoane si salvarea in .txt
        public People AddPeople(string name_people, string surname_people, DateTime date_of_birth, string t_number_people, string e_mail_people, string group_people_name)
        {
            try
            {
                People.count++;

                string aux = "\n" + People.count.ToString() + " " + name_people + " " + surname_people + " " + date_of_birth.ToString("yyyy-MM-dd") + " " + t_number_people + " " + e_mail_people + " " + group_people_name;
                File.AppendAllText(Program.path, aux);

                PeopleList.Add(new People(People.count, name_people, surname_people, date_of_birth, t_number_people, e_mail_people, group_people_name));
            }
            catch
            {
                return new People();
            }
            return new People();
        }

        //functia de modificarea datelor a unei persoane si salvarea in .txt
        public People EditPeople(int id_people, string name_people, string surname_people, string new_name_people, string new_surname_people, DateTime new_date_of_birth, string new_t_number_people, string new_e_mail_people, string new_group_people_name)
        {
            int i = 0;

            foreach (var s in data.PeopleDatabase.ToList())
            {
                try
                {
                    if (id_people == data.PeopleDatabase[i].id_people && name_people == data.PeopleDatabase[i].name_people && surname_people == data.PeopleDatabase[i].surname_people)
                    {
                        data.PeopleDatabase[i] = new People(data.PeopleDatabase[i].id_people, new_name_people, new_surname_people, new_date_of_birth, new_t_number_people, new_e_mail_people, new_group_people_name);
                        SaveToFile();
                    }
                    i++;
                }
                catch
                {
                    return new People();
                }
            }
            return new People();

        }

        //functia de steregere a unei persoane si salvarea in .txt
        public People DeletePeople(int id_people, string name_people, string surname_people)
        {
            foreach (var s in data.PeopleDatabase.ToList())
            {
                try
                {
                    if (id_people == s.id_people && name_people == s.name_people && surname_people == s.surname_people)
                    {
                        data.PeopleDatabase.Remove(s);
                        SaveToFile();
                    }
                }
                catch
                {
                    return new People();
                }
            }
            return new People();
        }

        //functia de rescriere a datelor in .txt
        public void SaveToFile()
        {
            File.WriteAllText(Program.path, string.Empty);

            foreach (var s in data.PeopleDatabase)
            {
                string aux = s.id_people + " " + s.name_people + " " + s.surname_people + " " + s.date_of_birth.ToString("yyyy-MM-dd") + " " + s.t_number_people + " " + s.e_mail_people + " " + s.group_people_name+ "\n";
                File.AppendAllText(Program.path, aux);
            }
        }
    } 
}
