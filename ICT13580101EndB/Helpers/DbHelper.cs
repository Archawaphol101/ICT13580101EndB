using System;
using ICT13580101EndB.Models;
using SQLite;

namespace ICT13580101EndB.Helpers
{
    public class DbHelper
    {
        SQLiteConnection db;
        public DbHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();
        }
        public int AddProduct(Product product)
        {
            //db.Insert(product);
            //return product.Id;
            db.Insert(product);
            return product.Id;
        }
    }
}
