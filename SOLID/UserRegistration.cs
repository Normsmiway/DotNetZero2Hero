using System.Collections.ObjectModel;

namespace SOLID
{
    
    public class UserRegistration
    {
        private readonly Collection<User> _usersStore;
        public UserRegistration(Collection<User> users)
        {
            _usersStore = users;
        }
        public void Register(string userId, string userName, string password)
        {
            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException(nameof(userName), $"{nameof(userName)} cannot be null or empty string");
            if (string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId), $"{nameof(userId)} cannot be null or empty string");
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password), $"{nameof(password)} cannot be null or empty string");

            var newUser = User.Register(userId, userName, password);
            _usersStore.Add(newUser);
        }
    }
}
