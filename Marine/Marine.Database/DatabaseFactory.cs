using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace Marine.Database
{
    public static class DatabaseFactory
    {
        private static Dictionary<string, DatabaseObj> DatabaseCollection = new Dictionary<string, DatabaseObj>();

        public static bool Add(string databaseName, DatabaseObj dbObj)
        {
            bool isAdd = false;

            try
            {
                if (DatabaseCollection.ContainsKey(databaseName))
                    return isAdd;
                DatabaseCollection.Add(databaseName, dbObj);
                isAdd = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return isAdd;
        }

        public static DatabaseObj GetDBObj(string dbName)
        {
            if (DatabaseCollection.ContainsKey(dbName))
                return DatabaseCollection[dbName];
            else
                return null;
        }

        public static DatabaseObj GetDBObjByConnetionString(string connectionString)
        {
            DatabaseObj dbObj = null;

            foreach (string dbKey in DatabaseCollection.Keys)
            {
                if (DatabaseCollection[dbKey].DbConnectionString == connectionString)
                {
                    dbObj = DatabaseCollection[dbKey];
                    break;
                }
            }
            return dbObj;
        }
    }
}