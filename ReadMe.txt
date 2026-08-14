The name of the project is ConsoleApp1, there's the Program class (the main Method), logo class and internal class named chatbot

Program class:
using System.Media and using ConsoleApp1 is used import the namespace audio related functionalities and the project's own custom namespace.
System.Media.SoundPlayer player = new System.Media.SoundPlayer allows the program to load and play a recorded voice file (such as the Greetings.wav file played at the start of your program).
PlaySync pauses execution until the audio finishes playing.
Logo logo = new Logo();: is to creates a new object (an instance) named logo from the Logo class in the project.
logo.DisplayLogo();: This calls the DisplayLogo() method stored inside that logo object, it triggers the code that changes the console text color and prints the ASCII art header and "Welcome to Cybersecurity Chatbot" banner when executed. 

Logo class:
Console.ForegroundColor changes text colours to Blue and Cyan
i used Console.WriteLine to display the Heading of the program(Welcome to Cybersecurity Chatbot) before displaying the logo which was made online in https://www.agenticbuilders.sg/logo-generator/.

internal class chat bot: 
This class is the Name Input & Validation; where the user is asked to enter their name using colored console text. A while loop is used to ensure the user doesn't submit a blank name. If left empty, it displays an error message in red and forces re-entry. if the name is entered, the bot displays "Welcome ", your name and "I am your Cybersecurity Chatbot" Awareness Chatbot". then it displays "ask me anything about staying safe online." Then there's an Interactive Conversation Loop(while loop), Listens for user input, converts it to lowercase, and checks for specific keywords (hello, purpose, password, phishing, safe browsing, help). This provides safety advice based on the topic the user asks about, or gives a fallback message if it doesn't understand the query. At the end of each question, it prompts the user to enter 1 to ask another question or 0 to exit, which controls the main while loop. when the user choose to exit, the program says "Thank you for using the Cybersecurity Awareness Chatbot!", then says "Stay safe online."
lastly, the program has a Typewriter Effect Method; Instead of dumping whole sentences onto the screen at once, this helper method loops through each character in a message and prints it with a 20-millisecond delay (Thread.Sleep(20)), creating a neat animated typing effect.
