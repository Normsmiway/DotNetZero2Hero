using System.Collections.ObjectModel;

namespace SOLID
{
    public abstract class UserAccess<LoginModel> where LoginModel : class
    {
        protected readonly Collection<User> _usersStore;
        public UserAccess(Collection<User> users)
        {
            _usersStore = users;
        }
        public abstract bool Login(LoginModel model);
    }
}
