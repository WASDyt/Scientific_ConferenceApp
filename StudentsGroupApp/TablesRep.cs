using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupApp
{
    public class TablesRep
    {
        SQLiteConnection database;
        public TablesRep(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Staff>();
            database.CreateTable<Conference>();
        }

        // Методы для таблицы Группы
        public IEnumerable<Staff> GetItemsStaff()
        {
            return database.Table<Staff>().ToList();
        }
        public Staff GetItemStaff(int id)
        {
            return database.Get<Staff>(id);
        }
        public int DeleteItemStaff(int id)
        {
            return database.Delete<Staff>(id);
        }
        public int SaveItemStaff(Staff item)
        {
            if (item.staffID != 0)
            {
                database.Update(item);
                return item.staffID;
            }
            else
            {
                return database.Insert(item);
            }
        }

        // Методы для таблицы Студенты
        public IEnumerable<Conference> GetItemsConference()
        {
            return database.Table<Conference>().ToList();
        }
        public Conference GetItemsConference(int id)
        {
            return database.Get<Conference>(id);
        }
        public int DeleteItemsConference(int id)
        {
            return database.Delete<Conference>(id);
        }
        public int SaveItemsConference(Conference item)
        {
            if (item.conferenceID != 0)
            {
                database.Update(item);
                return item.conferenceID;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
