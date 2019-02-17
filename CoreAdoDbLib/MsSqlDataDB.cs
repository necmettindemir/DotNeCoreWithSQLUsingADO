using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CoreAdoDbLib
{
    public class MsSqlDataDB : IDataDB
    {
        
        private readonly IConfiguration _configuration;

        public MsSqlDataDB(IConfiguration configuration)
        {           
            _configuration = configuration;
        }
            

        public Result GetUserList()
        {
            Result result = new Result { ResulCode = -1, ResultMessage = "" };

            try
            {
                SqlConnection sqlConn = new SqlConnection(_configuration.GetConnectionString("DBConnectionString"));

                string sql = "select * from Users";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, sqlConn);

                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds);

                result = new Result { ResulCode = 1, ResultMessage = "OK", Obj = ds};
                
            }
            catch (Exception ex)
            {

                result = new Result { ResulCode = -100, ResultMessage = "error :" + ex.Message };
            }


            return result;
        }

    }
}
