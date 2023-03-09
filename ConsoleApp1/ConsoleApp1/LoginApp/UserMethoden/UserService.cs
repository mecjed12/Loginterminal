using ConsoleApp1.LoginApp.loginData;

namespace ConsoleApp1.LoginApp.UserMethoden
{
    internal class UserService
    {
        Registring registring = new Registring();
        ConsoleHelper consoleHelper = new ConsoleHelper();


        public void CreateUser(List<User> userList)
        {
            var name = registring.RegastryName();
            var password = registring.RegastryPassword();
            consoleHelper.Printer("Sie haben sich erfolgreich registriert");
            var properties = new UserProperties(name, password);
            var user = new User(properties);
            userList.Add(user);
        }

        public bool LoginUser(List<User> users)
        {
            var user = FindUser(users);
            if (user == null)
            {
                return false;
            }

            consoleHelper.Printer("Bitte geben sie Jetz ihr passwort ein\n Sie haben 3 versuche");
            var password = consoleHelper.IntConvertor(consoleHelper.ReadInput());
            int counter = 3;
            for (int i = 0; i <= counter; i++)
            {
                if (password == user.UserProperties.Password)
                {
                    break;
                }
                else
                {
                    consoleHelper.Printer($"Sie haben das Passwort falsch eingegben bitte geben sie es erneut ein ");
                    consoleHelper.Printer($"Sie haben noch {counter - i} versuche");
                }
            }
            return true;
        }

        public User FindUser(List<User> users)
        {
            Thread.Sleep(3500);
            consoleHelper.Printer("Bitte geben Sie ihren Username ein");
            string requestedUserName = consoleHelper.ReadInput();
            foreach (var user in users)
            {
                if (user.UserProperties.Username == requestedUserName)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
