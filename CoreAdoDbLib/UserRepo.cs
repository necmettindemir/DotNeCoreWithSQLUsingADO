using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdoDbLib
{
    public class UserRepo : IUserRepo
    {
        
        private readonly IDataDB _dataDB;

        public UserRepo(IDataDB dataDB)
        {
            _dataDB = dataDB;
        }


        public Result GetUserList()
        {
            return _dataDB.GetUserList();

        }
    }
}
