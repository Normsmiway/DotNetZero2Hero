using System.Collections.ObjectModel;

namespace SOLID
{
    public class OTPBasedUserAccess : UserAccess<OTPLoginModel>
    {
        public OTPBasedUserAccess(Collection<User> users) : base(users)
        {
           
        }

        public override bool Login(OTPLoginModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.Otp))
                throw new ArgumentNullException("Invalid login parameter");

            var userExists = _usersStore.Any(x => x.UserName == model.UserName && x.Password == model.Password);
            return userExists;
        }
    }
}
