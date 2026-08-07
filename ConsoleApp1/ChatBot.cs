using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    internal class ChatBot
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter your name: ");
            Console.ResetColor();

            String userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                Console.ResetColor();

                userName = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            TypeText("\nWelcome " + userName + "!");
            Console.WriteLine();
            TypeText("I am your Cybersecurity Chatbot. Awareness Chatbot.");
            Console.WriteLine();
            TypeText("ask me anything about staying safe online.");
            Console.ResetColor();

            int response = 1;

            while (response == 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("You");
                Console.ResetColor();

                String question = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(question))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You didn’t enter anything. Please try again.");
                    Console.ResetColor();
                }
                else
                {
                    question = question.ToLower();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Bot: ");
                    Console.ResetColor();
                    if (question.Contains("hello") || question.Contains("hi"))
                    {
                        TypeText("Hello " + userName + "!It’s nice to meet you.");
                    }
                    else if (question.Contains("How are you"))
                    {
                        TypeText("I’m great, thank you for asking! I’m always ready to help you stay safe online.");
                    }
                    else if (question.Contains("purpose"))
                    {
                        TypeText("My purpose is to create awareness about cybersecurity and teach people how to stay safe online.");
                    }
                    else if (question.Contains("What can I ask") || question.Contains("help"))
                    {
                        Console.WriteLine();
                        Console.WriteLine(" – password Safety ");
                        Console.WriteLine(" – Phishing");
                        Console.WriteLine(" – safe Browsing");
                        Console.WriteLine(" – General cybersecurity");
                    }
                    else if (question.Contains("password"))
                    {
                        TypeText("Always create a strong password using uppercase letters, lowercase letters, numbers and symbols.");
                        Console.WriteLine();
                        TypeText("Never share your password with anyone.");
                    }
                    else if (question.Contains("phishing"))
                    {
                        TypeText("phishing is when criminals try to trick you into giving them personal information through fake emails, message or website.");
                    }
                    else if (question.Contains("safe browsing") || question.Contains("browsing"))
                    {
                        TypeText("Only visit trusted websites, avoid clicking suspicious links and always look for HTTPS when browsing.");
                    }
                    else
                    {
                        TypeText("I don’t understand that.Could to rephrase that ?");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter 1 to ask another question or 0 to exit: ");
                    Console.ResetColor();
                    response = Convert.ToInt32(Console.ReadLine());
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("=============================================================");
                Console.WriteLine("Thank you for using the Cybersecurity Awareness Chatbot!");
                Console.WriteLine("Stay safe online.");
                Console.WriteLine("=============================================================");
            }
        }
            public void TypeText(string message)
            {
                foreach (char letter in message)
                {
                    Console.Write(letter);
                    Thread.Sleep(20);
                }
            }
        }
    }

