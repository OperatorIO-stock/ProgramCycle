namespace ProgramCycle;

class Program
{
    static void Main(string[] args)
    {
        const string CommandExitProgram = "/exit";

        string messageUser;
        bool isWorkProgram = true;

        Console.WriteLine("Чтобы выйти из программы - /exit");

        while(isWorkProgram)
        {
            messageUser = Console.ReadLine();

            if (messageUser == CommandExitProgram)
            {
                isWorkProgram = false;
            }
        }

    }
}
