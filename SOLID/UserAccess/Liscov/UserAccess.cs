using System.Collections.ObjectModel;

namespace SOLID.UserAccess.Liscov
{

    public interface ILoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public interface IUserAccess
    {
        bool Login(ILoginModel model);
    }
    public abstract class UserAccess : IUserAccess
    {
        protected readonly Collection<User> _usersStore;
        public UserAccess(Collection<User> users)
        {
            _usersStore = users;
        }
        public abstract bool Login(ILoginModel model);
    }

    public class SimpleLoginAccess : UserAccess
    {
        protected readonly Collection<User> _usersStore;
        public SimpleLoginAccess(Collection<User> users) : base(users)
        {
        }

        public override bool Login(ILoginModel model)
        {
            return default;
        }
    }

    public class TwoFactoryUserAccess : UserAccess
    {
        protected readonly Collection<User> _usersStore;
        public TwoFactoryUserAccess(Collection<User> users) : base(users)
        {
        }

        public override bool Login(ILoginModel model)
        {
            return default;
        }
    }


    public class UserLogin
    {
        private readonly IUserAccess _userAccess;

        public UserLogin(IUserAccess userAccess)
        {
            _userAccess = userAccess;
        }
        public bool Login(ILoginModel loginModel)
        {
            return _userAccess.Login(loginModel);
        }
    }


    internal class UserLoginManager
    {
        private readonly IUserAccess _userAccess;
        private readonly Collection<User> _usersStore;

        public UserLoginManager()
        {
            _usersStore = new Collection<User>();
            _userAccess = new TwoFactoryUserAccess(_usersStore);
        }

        public void Login(ILoginModel login)
        {
            if (_userAccess.Login(login))
            {
                Console.WriteLine($"{login.UserName} logged in successfully");
            }
        }
    }
}
