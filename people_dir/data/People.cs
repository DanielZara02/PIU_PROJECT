using System;

namespace people_dir.data
{
    internal class People
    {

        public static int count = 0;

        public const int ID = 0;
        public const int NAME = 1;
        public const int SURNAME = 2;
        public const int DATE_OF_BIRTH = 3;
        public const int T_NUMBER = 4;
        public const int EMAIL = 5;
        public const int GROUP_NAME = 6;

        public int id_people { get; set; }
        public string name_people { get; set; }
        public string surname_people { get; set; }
        public DateTime date_of_birth { get; set; }
        public string t_number_people { get; set; }
        public string e_mail_people { get; set; }

        public string group_people_name { get; set; }

        public People()
        {
            name_people = surname_people = e_mail_people = group_people_name = t_number_people = string.Empty;
        }

        public People(int id_people, string name_people, string surname_people, DateTime date_of_birth, string t_number_people, string e_mail_people, string group_people_name)
        {
            this.id_people = id_people;
            this.name_people = name_people;
            this.surname_people = surname_people;
            this.date_of_birth = date_of_birth;
            this.t_number_people = t_number_people;
            this.e_mail_people = e_mail_people;
            this.group_people_name = group_people_name;
        }
    }
}