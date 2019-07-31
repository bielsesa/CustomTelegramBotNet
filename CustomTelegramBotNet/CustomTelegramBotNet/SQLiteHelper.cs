using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace CustomTelegramBotNet
{
    class SQLiteHelper
    {
        private static SQLiteConnection sQLiteCon = new SQLiteConnection(String.Format("Data Source={0}\\{1};Version=3;FailIfMissing=True;",
                                                    GlobalData.BuildDir, GlobalData.UserDbFilename));

        // public method to get currently registered users
        public static Dictionary<long, string> GetRegisteredUsers()
        {
            Dictionary<long, string> usersDict = new Dictionary<long, string>();
            DataSet usersDataSet = new DataSet();

            // try opening the DB and getting the user data
            try
            {
                sQLiteCon.Open();
                string commandText = "SELECT * FROM User";
                SQLiteDataAdapter SQLiteAdap = new SQLiteDataAdapter(commandText, sQLiteCon);
                SQLiteAdap.Fill(usersDataSet, "User");
                sQLiteCon.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error " + ex.ErrorCode + ": " + ex.Message);
            }

            // if there's data, insert it into the dictionary
            if (usersDataSet.Tables["User"] != null)
            {
                foreach (DataRow dataRow in usersDataSet.Tables["User"].Rows)
                {
                    try
                    {
                        usersDict.Add(long.Parse(dataRow["userId"].ToString()), dataRow["timeStamp"].ToString());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Couldn't convert ID to desired format.");
                    }
                }
            }

            return usersDict;
        }

        // public method to register new users
        public static void RegisterUser(long userId, string dateTime)
        {
            try
            {
                SQLiteParameter idParam = new SQLiteParameter("@idParam", DbType.Double),
                            timestampParam = new SQLiteParameter("@timestampParam", DbType.String);

                SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO User (userId, timeStamp) " +
                    "VALUES (@idParam,@timestampParam)", sQLiteCon);

                idParam.Value = userId;
                timestampParam.Value = dateTime;

                insertCmd.Parameters.Add(idParam);
                insertCmd.Parameters.Add(timestampParam);

                sQLiteCon.Open();
                insertCmd.ExecuteNonQuery();
                sQLiteCon.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error " + ex.ErrorCode + ": " + ex.Message);
            }
        }
    }
}
