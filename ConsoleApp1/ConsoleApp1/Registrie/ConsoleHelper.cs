

using ConsoleApp1.LoginApp.UserMethoden;

namespace ConsoleApp1.LoginApp
{
    internal class ConsoleHelper
    {
        public void Printer(string output)
        {
            Console.WriteLine(output);
        }
        public int IntConvertor (string number)
        {          
            return Convert.ToInt32(number);
        }
        public int IntConvertor(int number)
        {
            return Convert.ToInt32(number);
        }

        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public void PrintTheUser (string name, int password)
        {
            Thread.Sleep(3000);
            Printer($"Willkomen : {name}");
            Printer($"Der Username ist : {name} \nUnd ihr Passwort ist : {password}");            
        }
        public string PrintArray(string[] listElements)
        {
           
            for (int i = 0; i < listElements.Length; i++)
            {
                Printer(listElements[i]);
            }
            return   string.Join(Environment.NewLine, listElements);
        }
        public void PrintAllUsers (List<User> StoredUsers)
        {
            foreach (User user in StoredUsers)
            {
                Console.WriteLine($"Username : {user.UserProperties.Username}, Passwort : {user.UserProperties.Password} ");
            }
        }
        public void EnumListPrint (List<User> options)
        {
            foreach(Enum option in Enum.GetValues(options.GetType()))
            {
                Console.WriteLine(option.ToString());
            }
        }
    }
}
