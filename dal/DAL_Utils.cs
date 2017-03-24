using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class DAL_Utils
    {

        /// Build ConnectionString
        /// Input : server name, database name
        /// Output : ConnectionString
        public static string BuildConnectionString(string server, string db, string UserName, string Password, bool IntegratedSecurity)
        {
            return "Data Source=" + server.Trim() + ";Initial Catalog=" + db.Trim() + ";Integrated Security=" + IntegratedSecurity + ";User ID=" + UserName.Trim() + ";Password=" + Password + ";";
        }

        public static string BuildConnectionString(string server, string db, bool IntegratedSecurity)
        {
            return "Data Source=" + server.Trim() + ";Initial Catalog=" + db.Trim() + ";Integrated Security=" + IntegratedSecurity + ";";
        }

        public static string BuildConnectionString(string server, bool IntegratedSecurity)
        {
            return "Data Source=" + server.Trim() + ";Integrated Security=" + IntegratedSecurity + ";";
        }

        public static string BuildConnectionString(string server, string UserName, string Password, bool IntegratedSecurity)
        {
            return "Data Source=" + server.Trim() + ";Integrated Security=" + IntegratedSecurity + ";User ID=" + UserName.Trim() + ";Password=" + Password + ";";
        }

        /// Connect to server, connect to database 
        /// Input : connection string
        /// Output : true - yes, false -no
        public static bool ConnectToServer(string connectionString)
        {

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ConnectToDatabase(string connectionString)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// Create new database from script file
        /// input : string connection strings, string path file
        /// output : true-yes, false-no   
        public static bool CreateNewDatabaseFromFileScript(string connectionString, string databaseName, string path)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string strscript = File.ReadAllText(path);
                string[] allCmd = strscript.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = connection;
                connection.Open();

                sqlCmd.CommandText = " USE [master]";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "CREATE DATABASE [" + databaseName + "]";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "USE [" + databaseName + "]";
                sqlCmd.ExecuteNonQuery();

                for (int i = 0; i < allCmd.Length; i++)
                {
                    sqlCmd.CommandText = allCmd[i];
                    sqlCmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;

            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }
        }

        public static bool DropDatabase(string connectionString, string db)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("ALTER DATABASE " + db + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", connection);
                cmd.CommandType = CommandType.Text;

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Drop Database " + db.Trim();

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }
        }

        public static bool CreateSmapleDB(string connectionString, string path)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string strscript = File.ReadAllText(path);
                string[] allCmd = strscript.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = connection;

                connection.Open();
                for (int i = 0; i < allCmd.Length; i++)
                {
                    sqlCmd.CommandText = allCmd[i];
                    sqlCmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;

            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }

        }



        /// Get current InstanceName in machine
        /// in:
        /// out: instance name
        public static List<string> GetInstanceName()
        {
            List<string> instanceNameArr = new List<string>();

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        instanceNameArr.Add(instanceName);
                    }
                }
            }
            return instanceNameArr;
        }

        public static List<string> GetAllServerName()
        {
            List<string> allInstance = GetInstanceName();
            List<string> allServerName = new List<string>();
            string macineName = Environment.MachineName;
            allServerName.Add(macineName);
            foreach (string s in allInstance)
            {
                allServerName.Add(macineName + @"\" + s);
            }
            return allServerName;
        }


        /// convert password to MD5 string
        /// in:
        /// out: instance name
        public static string ConvertPassToMD5(string passw)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.ASCII.GetBytes(passw));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


    }
}
