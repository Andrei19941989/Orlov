using System;

namespace Teenweb
{
    class Program
    {



        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();

            /*Console.WriteLine("Hello it is TeenWeb! Please sign in or sign up(1 - sign in, 2 - sign up)");

            string command = Console.ReadLine();
            while (command != "1" && command != "2")
            {
                command = Console.ReadLine();
            }

            if (command == "1")
            {
                Console.Write("Please input your login: ");
                string login = Console.ReadLine();

                User user = userManager.Get(login);

                Console.Write("Please input your password: ");
                string password = Console.ReadLine();
                if (user.Password == password)
                {
                    Console.WriteLine("OK");

                }
                else
                {
                    Console.WriteLine("No");
                }

            }
        
                if (command == "2")
            {
                Console.WriteLine("Please input your login,password,name, surname, age, citizenship, city, sex, views, religion, number, work, campus, languages, friends, handing:");
                string login = Console.ReadLine();
                string password = Console.ReadLine();
                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                string citizenship = Console.ReadLine();
                string city = Console.ReadLine();
                string sex = Console.ReadLine();
                string views = Console.ReadLine();
                string religion = Console.ReadLine();
                string number = Console.ReadLine();
                string work = Console.ReadLine();
                string campus = Console.ReadLine();
                int languages = Convert.ToInt32(Console.ReadLine());
                int friends = Convert.ToInt32(Console.ReadLine());
                string handing = Console.ReadLine();
                userManager.Create(login, password, name, surname, age, citizenship, city, sex, views, religion, number, work, campus, languages, friends, handing);
                Console.WriteLine("done");
            }
            Console.ReadKey();*/

            userManager.UpdateName("Gopr458", "Zaurbek");

            Console.WriteLine("Done");




            //userManager.Create("Blacklife1994", "pass1", "Andrei", "Orlov", 27, "РФ", "Moscow", "male", "liberal",
            //    "katolic", "79998283019", "programmer", "Cambridge", 3,
            //       2, "Ok");
            /* userManager.Create(///);-создать нескольок пользователей*/
            /* userManager.Create("Lop1983", "pass2", "Vova", "Korean", 25, "РФ", "Piter",
             "male", "liberal","katolic", "79998303519", "prodavec", "Oxford", 2, 3, "Ok");*/
            /*userManager.Create("Topr43", "pass3", "Ira", "Orlova", 33, "РФ", "Moscow",
         "female", "liberal", "katolic", "79258348519", "doctor", "Oxford", 4, 1, "Ok");*/
            /*userManager.Create("Pol19941", "pass4", "Ekaterina", "Bocho", 29, "Рф", "Moscow",
                "female", "ленинизм", "katolic", "7928428381019", "medic", "Miit", 2, 5, "Ok");*/
            /* userManager.Create("Wepok984", "pass5", "Max", "Golden", 28, "USA", "California",
                "male", "cohial", "katolic", "7252283014", "student", "МГУ", 2, 2, "OK");*/
            /*userManager.Create("Gopr458", "pass6", "Nikita", "Dobrov", 19, "Рф", "Novgorod",
                "male", "liberal", "pravosclavniy", "79590283079", "student", "Sochi", 2, 1, "Ok");*/
            /* userManager.Create("Rotyh657j", "pass7", "Iasbela", "Bopr", 23, "Izrael", "Ierusalim", "female",
                "liberal", "katolic", "7283243019", "student", "Baumana", 2, 1, "OK");*/
            //userManager.Create("Kotf768i", "pass8", "Ofelia", "Polaska", 26, "Poland", "Varshava",
            //    "female", "liberal", "muslim", "782547835", "teacher", "Baumana", 1, 3, "OK");


            /*string login = "Pol19941";

            string s = "Your login is " + login;
            string s2 = $"Your login is {login}";
            Console.WriteLine(s);
            Console.WriteLine(s2);*/

            //User u = userManager.Get(login);

            //Console.WriteLine(u.Password);
            //userManager.Delete("Rotyh657j");






        }
    }
}
