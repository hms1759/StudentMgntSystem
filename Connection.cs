using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgntSystem
{
    public static  class DBconnect 
    {
      public  static string DbConnectstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolMgnDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }

    public static class LoginDetails
    {
        private static string username;
        public static string LoginName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public static string LoginPassword { get; set; }
    }
}
