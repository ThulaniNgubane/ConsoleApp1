
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace ConsoleApp1;
    public class Logo
    {
        public void DisplayLogo()
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=============================================================");
        Console.WriteLine("Welcome to CyberSecurity Chatbot");
        Console.WriteLine("=============================================================");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"

████████╗  ██████╗   ██████╗  ██╗      ███████╗
╚══██╔══╝ ██╔═══██╗ ██╔═══██╗ ██║      ██╔════╝
   ██║    ██║   ██║ ██║   ██║ ██║      ███████╗
   ██║    ██║   ██║ ██║   ██║ ██║      ╚════██║
   ██║    ╚██████╔╝ ╚██████╔╝ ███████╗ ███████║
   ╚═╝     ╚═════╝   ╚═════╝  ╚══════╝ ╚══════╝
===============================================
C Y B E R S E C U R I T Y   C H A T B O T ");
            
        }
    }
