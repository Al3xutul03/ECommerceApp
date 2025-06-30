using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.DataFormats
{
    [Serializable]
    public class Account
    {
        public int id;
        public string username;
        public string email;
        public string password;

        public Account(DataRow row)
        {
            this.id = (int)row[0];
            this.username = (string)row[1];
            this.email = (string)row[2];
            this.password = (string)row[3];
        }
    }
}
