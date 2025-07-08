using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utils.DataFormats
{
    [Serializable]
    [XmlRoot("AccountCollection")]
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CreationDate { get; set; }

        public Account() { }

        public Account(int id, string username, string email, string password, string creation_date)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.CreationDate = creation_date;
        }

        public Account(DataRow row)
        {
            this.Id = (int)row[0];
            this.Username = (string)row[1];
            this.Email = (string)row[2];
            this.Password = (string)row[3];
            this.CreationDate = ((DateTime)row[4]).ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return Username;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Account)) return false;
            Account other = (Account)obj;
            return this.Id == other.Id &&
                   this.Username == other.Username &&
                   this.Email == other.Email &&
                   this.Password == other.Password &&
                   this.CreationDate == other.CreationDate;
        }
    }

    [Serializable]
    [XmlRoot("AccountCollection")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Product() { }

        public Product(int id, string name, string producer, float price, int stock, string category, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Producer = producer;
            this.Price = price;
            this.Stock = stock;
            this.Category = category;
            this.Description = description;
        }

        public Product(DataRow row)
        {
            this.Id = (int)row[0];
            this.Name = (string)row[1];
            this.Producer = (string)row[2];
            this.Price = (float)row[3];
            this.Stock = (int)row[4];
            this.Category = (string)row[5];
            this.Description = (string)row[6];
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Account)) return false;
            Product other = (Product)obj;
            return this.Id == other.Id &&
                   this.Name == other.Name &&
                   this.Producer == other.Producer &&
                   this.Price == other.Price &&
                   this.Stock == other.Stock &&
                   this.Category == other.Category &&
                   this.Description == other.Description;
        }
    }

    public enum DataType
    {
        Account, Product
    }
}
