using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Teenweb
{
    public class UserManager
    {
        private string connectionString =
            "Server=127.0.0.1;Database=Teenweb;UID=root;PWD=Plm19941967";

        private string userTableName = "User";

        public UserManager(string connectionString,string userTableName)
        {
            this.connectionString = connectionString;
            this.userTableName = userTableName;
        }
        public UserManager()
        {

        }

        public void Create(string login,string password,string name,
            string surname, int age,string citizenship, string city, string sex, string views,
            string religion, string number, string work, string campus,
            int languages, int friends, string handing)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"insert into {userTableName} (login, password, name, surname, age, citizenship, city, sex, views, religion, number, work, campus, languages, friends, handing) values ('{login}','{password}','{name}','{surname}','{age}','{citizenship}','{city}','{sex}','{views}','{religion}','{number}','{work}','{campus}','{languages}','{friends}','{handing}')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
               

        }


        public User Get(string login)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT login, password, name, surname, age, citizenship, city, sex, views, religion, number, work, campus, languages, friends, handing " +
                $"FROM {userTableName} WHERE login = '{login}'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine(reader.HasRows);
            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();

            login = reader.GetString(0);
            string pass = reader.GetString(1);
            string name = reader.GetString(2);
            string surname = reader.GetString(3);
            int age = reader.GetInt32(4);
            string citizenship = reader.GetString(5);
            string city = reader.GetString(6);
            string sex = reader.GetString(7);
            string views = reader.GetString(8);
            string religion = reader.GetString(9);
            string number = reader.GetString(10);
            string work = reader.GetString(11);
            string campus = reader.GetString(12);
            int languages = reader.GetInt32(13);
            int friends = reader.GetInt32(14);
            string handing = reader.GetString(15);


            User u = new User(login, pass, name, surname, age, citizenship, city, sex, views,
                religion, number, work, campus, languages, friends, handing);
            reader.Close();
            connection.Close();
            return u;
        }

        public void Delete(string login)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"DELETE FROM {userTableName} WHERE login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void Update(string login, string password, string name,
            string surname, int age, string citizenship, string city, string sex, string views,
            string religion, string number, string work, string campus,
            int languages, int friends)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE {userTableName} SET name = '{name}', " +
                $"password='{password}', " +
                $"city='{city}', " +
                $"sex = '{sex}', " +
                $"views ='{views}', " +
                $"number='{number}', " +
                $"campus = '{campus}', " +
                $"friends='{friends}', " +
                $"age='{age}', " +
                $"surname='{surname}', " +
                $"citizemship='{citizenship}', " +
                $"religion='{religion}', " +
                $"work='{work}', " +
                $"languages='{languages}', " +
                $"WHERE login = '{login}'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateName(string login, string name)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE {userTableName} SET name = '{name}' WHERE login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateSurname(string login, string surname)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE {userTableName} SET surname = '{surname}' WHERE login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteAll()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"DELETE FROM {userTableName}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
