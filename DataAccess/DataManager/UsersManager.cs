using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using DataObject;
using Utilities;

using System.Data.OleDb;
using System.Data;

namespace DataManager
{
    public class UsersManager
    {
        private string fileName = "";
        public UsersManager()
        {
            fileName = @"C:\SVN Training\Kadiwa Archive\kadiwa_archive\DataAccess\App_Data\main.accdb";
        }

        public void Login (Users users, UsersOutput usersOutput)
        {

            usersOutput.responsecode = ResponseCodes.Fail;

            try
            {
                using (OleDbConnection conn = new OleDbConnection { ConnectionString = fileName.BuildConnectionString() })
                {
                    using (OleDbCommand cmd = new OleDbCommand { Connection = conn })
                    {
                        cmd.CommandText = "SELECT * FROM tblUsers WHERE username = @username AND password = @password";
                        cmd.Parameters.AddWithValue("@username", users.username);
                        cmd.Parameters.AddWithValue("@password", users.password);

                        DataTable dataTable = new DataTable();
                        conn.Open();
                        dataTable.Load(cmd.ExecuteReader());

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];
                            usersOutput.status = row["status"].ToString().Trim();
                            usersOutput.message = "Success";
                            usersOutput.responsecode = ResponseCodes.Success;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                usersOutput.message = ex.Message;
                usersOutput.responsecode = ResponseCodes.Fail;
            }
        }

    }
}
