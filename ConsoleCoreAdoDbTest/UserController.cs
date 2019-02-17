using CoreAdoDbLib;
using Microsoft.Extensions.Configuration;


namespace ConsoleCoreAdoDbTest
{
    
    public class UserController
    {
        private readonly IUserRepo _userRepo;        

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;            
        }

        public Result GetUserList()
        {
            Result result = _userRepo.GetUserList();
            return result;

        }

    }
    
}
