namespace SOLID
{
    public class DefaultLoginModel
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public DefaultLoginModel(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public static DefaultLoginModel Create(string userName, string password)
        {
            return new(userName, password);
        }
    }
}
