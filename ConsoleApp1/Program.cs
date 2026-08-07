
using System.Media;
using ConsoleApp1; 

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main (string[] args)
        {
            // Replace "Voice/greeting.wav" with the actual path to your recorded voice file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\Student\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net10.0\\Voice\\Greetings.wav");

            player.PlaySync();
            //Console.WriteLine(" ");
            Logo logo = new Logo();
            logo.DisplayLogo();

            ChatBot bot = new ChatBot();
            bot.Start();

        }
    }
}
