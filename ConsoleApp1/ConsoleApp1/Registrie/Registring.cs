namespace ConsoleApp1.LoginApp.loginData
{
    internal class Registring
    {
        ConsoleHelper consoleHelper = new ConsoleHelper();

        public string RegastryName()
        {
            consoleHelper.Printer("Bitte geben Sie Ihre Namen ein ");
            var name = consoleHelper.ReadInput();
            int number;
            bool typtester = false;
            while (!typtester)
            {
                if (name != null)
                {
                    if (int.TryParse(name, out number))
                    {
                        consoleHelper.Printer("Bitte geben sie Buchstaben und keine nummern");
                        name = consoleHelper.ReadInput();
                    }
                    else
                    {
                        typtester = true;
                    }
                }
                else
                {
                    return null;
                }
            }
            return name;
        }

        public int RegastryPassword()
        {
            Thread.Sleep(1000);
            consoleHelper.Printer("Bitte geben Sie ihr gewünschtes Passwort ein ");
            var password = consoleHelper.ReadInput();
            int number;
            bool typtester = false;
            while (!typtester)
            {
                if (password != null)
                {
                    if (int.TryParse(password, out number))
                    {
                        typtester = true;
                    }
                    else
                    {
                        consoleHelper.Printer("Bitte geben sie eine Nummer ein und keinen Buchstaben");
                        password = consoleHelper.ReadInput();
                    }
                }
            }
            return consoleHelper.IntConvertor(password);
        }
    }
}
