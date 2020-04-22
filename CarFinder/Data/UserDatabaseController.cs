using System;
using CarFinder.Models;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace CarFinder.Data
{
    public class UserDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public UserDatabaseController()
        {
            //passes in table from database to be populated
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        //method to Add a user to Database
        public string AddUser(User user)
        {
            var data = database.Table<User>();
            var d1 = data.Where(x => x.password == user.password && x.userName == user.userName).FirstOrDefault();
            if (d1 == null)
            {
                database.Insert(user);
                return "Sucessfully Added";
            }
            else
                return "USer Exist";


        }


        //gets user from database to loaded
        public User GetUser()
        {
            lock (locker)
            {
                if(database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }
           
        }

        //Saves information for user 
        public int SaveUser(User user)
        {
            lock (locker)
            {
                if (user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }

                else
                {
                    return database.Insert(user);
                }
            }
        }

        //method to validate login information
        public bool LoginValidate(string userName1, string pwd1)
        {
            var data = database.Table<User>();
            var d1 = data.Where(x => x.userName == userName1 && x.password == pwd1).FirstOrDefault();

            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }



       
    }
}
