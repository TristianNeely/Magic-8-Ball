using System;

namespace Magic_8_Ball
{
    class Program
    {
        //First Magic 8 Ball is nothing more than a random number generator.
        // SO we are going to create an object that will basically be a randon number.
        static Random randomObject = new Random();


        static void Main(string[] args)
        {
            QuestionLoop();
        }
        static string GetQuestionFromUser()
        {
            Console.Write("What question do you have?");
            string questionString = Console.ReadLine();
            return questionString;
        }
        static void QuestionLoop()
        {
            while (true)
            {
                string questionString = GetQuestionFromUser();
                int randomNumber = randomObject.Next(10);
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("That's a mystery for the ages!");
                                break;
                        }
                    case 4:
                        {
                            Console.WriteLine("I would make donuts instead.");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Your teacher is a ninja, Be nice.");
                            break;

                        }
                    case 6:
                        {
                            Console.WriteLine("42. it's the answer to everything");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Stop asking questions and make me a pizza!");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Maybe");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("This isn't Canada, Speak English");
                            break;
                        }

                }
            }
        }
    }
}
