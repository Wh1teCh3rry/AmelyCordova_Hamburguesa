using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmelyCordova_Hamburguesa.Models;
using SQLite;

namespace AmelyCordova_Hamburguesa.Data
{
    public class AC_BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public AC_BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<AC_Burger>();
        }
        public int AC_AddNewBurger(AC_Burger burger)
        {
            Init();
            //Ya no necesito que los campos se muestren vacíos
            //int result = conn.Insert(burger);
            //return result;

            //Valido si la hamburguesa existe, si sí se hace Update, sino se hace Insert
            if (burger.Id != 0)
            {
                return conn.Update(burger);
            }
            else
            {
                return conn.Insert(burger);
            }
        }
        public List<AC_Burger> AC_GetAllBurgers()
        {
            Init();
            List<AC_Burger> burgers = conn.Table<AC_Burger>().ToList();
            return burgers;
        }

        public int AC_DeleteItem(AC_Burger burger)
        {
            Init();
            return conn.Delete(burger);
        }
    }
}