namespace SOLID
{
    public class OTPLoginModel
    {
        public string Otp { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        private OTPLoginModel(string userName, string password, string otp)
        {
            UserName = userName;
            Password = password;
            Otp = otp;
        }

        public static OTPLoginModel Create(string userName, string password, string otp)
        {
            return new(userName, password, otp);
        }
    }
}
