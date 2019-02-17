using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdoDbLib
{
    public class MySqlDataDB : IDataDB
    {
        private readonly IConfiguration _configuration;

        public MySqlDataDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Result GetUserList()
        {
            Result result = new Result { ResulCode = -1, ResultMessage = "" };

            //mysql operations

            return result;
        }
    }
}
