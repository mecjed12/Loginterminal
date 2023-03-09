using ConsoleApp1.Registrie;

namespace ConsoleApp1.LoginApp.UserMethoden
{
    internal class UserInterface
    {

        ConsoleHelper consoleHelper = new ConsoleHelper();
        UserService userService = new UserService();
        UserOptions userOptions = new UserOptions();

        public List<User> StoredUsers { get; set; } = new List<User>();
        public void Main()
        {

            UserOptions userOptions = new UserOptions();
            Start();
        }
        public void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                consoleHelper.Printer("Wollen sie fortfahren Y = weiter und N = für Nein");
                ConsoleKeyInfo decision = Console.ReadKey();
                if (decision.Key == ConsoleKey.Y)
                {
                    var requestedOption = userOptions.OptionsAvailable();
                    switch (requestedOption)
                    {
                        case Options.NewUserRegistry:
                            userService.CreateUser(StoredUsers);
                            break;


                        case Options.Login:
                            userService.LoginUser(StoredUsers);
                            break;

                        case Options.OutputofAllUser:
                            consoleHelper.PrintAllUsers(StoredUsers);
                            break;
                    }
                }
                else if (decision.Key == ConsoleKey.N)
                {
                    consoleHelper.Printer("Auf Wiedersehen");
                    break;
                }

            }
        }

       
    }
}
