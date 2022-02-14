using System;
namespace Teenweb
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Citizenship { get; }
        public string City { get; }
        public string Sex { get; }
        public string Views { get; }
        public string Religion { get; }
        public string Number { get; }
        public string Work { get; }
        public string Campus { get; }
        public int Languages { get; }
        public int Friends { get; }
        public string Handing { get; }

        public User(string login,string password,string name,string surname,
            int age,string citizenship,string city,string sex,string views,
            string religion,string number,string work,string campus,
            int languages,int friends,string handing)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Age = age;
            Citizenship = citizenship;
            City = city;
            Sex = sex;
            Views = views;
            Religion = religion;
            Number = number;
            Work = work;
            Campus = campus;
            Languages = languages;
            Friends = friends;
            Handing = handing;


        }

      
    }
}
