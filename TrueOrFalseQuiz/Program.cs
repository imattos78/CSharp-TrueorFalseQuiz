using System;

namespace TrueOrFalseQuiz
{
    class Program
    {
        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
                Console.WriteLine("Error in the Length of question / answer arrays!!");

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
               
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False Quiz'\nPress 1-Science / 2-General / 3-Films:");
            string entry = Console.ReadLine();

            string[] science = {
        "Question 1 - Electrons are larger than molecules",
        "Question 2 - The Atlantic Ocean is the biggest ocean on Earth.",
        "Question 3 - Sharks are mammals.",
        "Question 4 - The human body has four lungs.",
        "Question 5 - Atoms are most stable when their outer shells are full.",
        "Question 6 - Venus is the closest planet to the Sun.",
        "Question 7 - Conductors have low resistance.",
        "Question 8 - Molecules can have atoms from more than one chemical element."
      };
            bool[] scAnswers = {
        false, false, false, false, true, false, true, true
      };

            string[] pub = {
        "Question 1 - Cyclones spin in a clockwise direction in the southern hemisphere",
        "Question 2 - Goldfish only have a memory of three seconds",
        "Question 3 - The capital of Libya is Benghazi",
        "Question 4 - Brazil is the only country in the Americas to have the official language of Portuguese",
        "Question 5 - The Channel Tunnel is the longest rail tunnel in the world",
        "Question 6 - Darth Vader famously says the line “Luke, I am your father” in The Empire Strikes Back",
        "Question 7 - Stephen Hawking declined a knighthood from the Queen",
        "Question 8 - Nicolas Cage and Michael Jackson both married the same woman"
      };
            bool[] pubAnswers = {
        true, false, false, true, false, false, true, true
      };
            string[] films = {
        "Question 1 -John Wayne starred in 'A Fistful of Dollars'",
        "Question 2 - Shere Khan is a snake",
        "Question 3 - Sean Connery was born in the 1940s",
        "Question 4 - Leonardo DiCaprio's character in Titanic was called 'Jack'",
        "Question 5 - Robert De Niro won an Oscar for 'Raging Bull'",
        "Question 6 -  in 'Star Wars,' Princess Leia's home planet is Hoth",
        "Question 7 - Jennifer Lawrence played Storm in the X-Men films",
        "Question 8 - Ursula is a character in 'The Little Mermaid'"
      };
            bool[] filmAnswers = {
        false, false, false, true, true, false, false, true
      };

        }
    }
}
