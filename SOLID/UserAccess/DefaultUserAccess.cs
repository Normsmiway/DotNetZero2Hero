using System.Collections.ObjectModel;

namespace SOLID
{
    /*
     * Add 2FAC Auth to your login process
     */
    public class DefaultUserAccess : UserAccess<DefaultLoginModel>
    {
        public DefaultUserAccess(Collection<User> users) : base(users)
        {
        }

        public override bool Login(DefaultLoginModel model)
        {
            //check if user exists
            //check if username/password match
            var userExists = _usersStore.Any(x => x.UserName == model.UserName && x.Password == model.Password);

            //return login status
            return userExists;
        }
    }
}
