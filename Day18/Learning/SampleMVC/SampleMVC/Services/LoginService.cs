using SampleMVC.Models;

namespace SampleMVC.Services
{
    public class LoginService
    {
        private IRepo<string, User> _repo;

        public LoginService(IRepo<string, User> repo)
        {
            _repo = repo;
        }

        public User LoginCheck(User user)
        {
            var myUser = _repo.GetT(user.Username);
            if(myUser != null)
            {
                if(myUser.Password == user.Password)
                {
                    user.Password = null;
                    return user;
                }
            }
            return null;
        }
    }
}
