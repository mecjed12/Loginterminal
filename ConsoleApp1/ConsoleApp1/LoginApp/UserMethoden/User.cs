namespace ConsoleApp1.LoginApp.UserMethoden
{
    internal class User
    {
        public UserProperties UserProperties { get; set; }

        public User(UserProperties userProperties)
        {
            UserProperties = userProperties;
        }

        public User()
        {
        }
    }

}
