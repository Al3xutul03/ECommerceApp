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
        public string creation_date;

        public Account(int id, string username, string email, string password, string creation_date)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.creation_date = creation_date;
        }

        public Account(DataRow row)
        {
            this.id = (int)row[0];
            this.username = (string)row[1];
            this.email = (string)row[2];
            this.password = (string)row[3];
            this.creation_date = ((DateTime)row[4]).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public override string ToString()
        {
            return username;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Account)) return false;
            Account other = (Account)obj;
            return this.id == other.id &&
                   this.username == other.username &&
                   this.email == other.email &&
                   this.password == other.password &&
                   this.creation_date == other.creation_date;
        }
    }

    [Serializable]
    public class Product
    {
        public int id;
        public string name;
        public string producer;
        public float price;
        public int stock;
        public string category;
        public string description;

        public Product(int id, string name, string producer, float price, int stock, string category, string description)
        {
            this.id = id;
            this.name = name;
            this.producer = producer;
            this.price = price;
            this.stock = stock;
            this.category = category;
            this.description = description;
        }

        public Product(DataRow row)
        {
            this.id = (int)row[0];
            this.name = (string)row[1];
            this.producer = (string)row[2];
            this.price = (float)row[3];
            this.stock = (int)row[4];
            this.category = (string)row[5];
            this.description = (string)row[6];
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Account)) return false;
            Product other = (Product)obj;
            return this.id == other.id &&
                   this.name == other.name &&
                   this.producer == other.producer &&
                   this.price == other.price &&
                   this.stock == other.stock &&
                   this.category == other.category &&
                   this.description == other.description;
        }
    }
}
