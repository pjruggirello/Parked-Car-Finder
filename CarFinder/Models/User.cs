using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CarFinder.Models
{
    //Creates the Table User
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public User() { }
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        //Validates username and login infromation 
        public bool CheckInformation()
        {
            if(!this.userName.Equals("") && !this.password.Equals(""))
                return true;
            else
                return false;
        }
    
    }
}
