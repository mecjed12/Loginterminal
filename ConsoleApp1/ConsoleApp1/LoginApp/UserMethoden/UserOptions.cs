using ConsoleApp1.Registrie;

namespace ConsoleApp1.LoginApp.UserMethoden
{
    internal class UserOptions
    {
        ConsoleHelper consoleHelper = new ConsoleHelper();
        UserService userService = new UserService();

        public Options OptionsAvailable()
        {
            consoleHelper.Printer("Sie können Diese Optionen auswählen");

            var temp = Enum.GetNames<Options>();



            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine($" {i} for " + temp[i]);
            }

            consoleHelper.Printer("");
            consoleHelper.Printer("Geben Sie Ihre Nummer ein");
            var userInput = consoleHelper.IntConvertor(consoleHelper.ReadInput());
            switch (userInput)
            {
                case 1:
                    return Options.NewUserRegistry;

                case 2:
                    return Options.Login;

                case 3:
                    return Options.OutputofAllUser;

                default:
                    consoleHelper.Printer("Ungültige Eingabe, Bitte wählen Sie eine der verfügbare Options");
                    return Options.ProgrammExit;
            }
        }

    }
}
