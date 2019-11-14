using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class System_User_Modle
    {
        private int iD;
        private string userName;
        private string password;
        private string userLevel;
        private string userOPLevel;

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string UserLevel { get => userLevel; set => userLevel = value; }
        public string UserOPLevel { get => userOPLevel; set => userOPLevel = value; }
    }
}
