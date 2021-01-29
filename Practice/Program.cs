using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Questions();
        }
        static void Intro()
        {
            Console.WriteLine("Here is your Pokemon Quiz to see if you're ready to be a Pokemon trainer!");
            Console.WriteLine("You have 10 questions and they must all be answered correctly, so good luck!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
        static void Questions()
        {
            string[] question = new string[10];
            string[] answer = new string[10];
            string[] wrong = new string[10];

            string userAnswer;
            int correct = 0;
            int incorrect = 0;

            question[0] = "Q1. Which of these is a Grass-type?\nA. Sudowoodo\nB. Bulbasaur\nC. Marshtomp\nD. Pikachu";
            question[1] = "Q2. Ground attacks are more effective against Fire-types.\nA. True\nB. False";
            question[2] = "Q3. Chikorita evolves into which Pokemon?\nA. Torchic\nB. No evolution\nC. Ivysaur\nD. Bayleef";
            question[3] = "Q4. Which of these Pokemon can learn the move Fly?\nA. Dodrio\nB. Scyther\nC. Magnemite\nD. Geodude";
            question[4] = "Q5. What is the first gym you go to in th generation I Pokemon games?\nA. Cerulean Gym\nB. Oreburgh Gym\nC. Rustboro Gym\nD. Pewter Gym";
            question[5] = "Q6. Tyranitar is a legendary Pokemon.\nA. True\nB. False";
            question[6] = "Q7. How many generation of Pokemon games has there been?\nA. 5\nB. 6\nC. 7\nD. 8";
            question[7] = "Q8. How many Pokemon are there in total?\nA. 807\nB. 658\nC. 934\nD. 588";
            question[8] = "Q9. In the national Pokedex who is entry 001?\nA. Pikachu\nB. Charmander\nC. Bulbasaur\nD. Squirtle";
            question[9] = "Q10. At what age can you set out on your adventure to become a Pokemon trainer?\nA. 10\nB. 15\nC. 13\nD. 16";

            answer[0] = "B";
            answer[1] = "A";
            answer[2] = "D";
            answer[3] = "A";
            answer[4] = "D";
            answer[5] = "B";
            answer[6] = "C";
            answer[7] = "A";
            answer[8] = "C";
            answer[9] = "A";

            for (int x = 0; x < question.Length; x++)
            {
                Console.WriteLine(question[x]);
                userAnswer = Console.ReadLine();
                if (userAnswer.ToUpper() == answer[x])
                {
                    correct++;
                }
                else
                {
                    incorrect++;
                    wrong[x] = "wrong";
                }
                Console.Clear();
            }
            //Second round of incorrect questions.
            {
                if (incorrect > 0)
                    Console.WriteLine("you got " + incorrect + " wrong, you will now be given a second attempt on those questions, good luck!\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
            }       
            
            {
                for (int x = 0; x < question.Length; x++)
                {
                    if (wrong[x] == "wrong")
                    {
                        Console.WriteLine(question[x]);
                        userAnswer = Console.ReadLine();
                        if (userAnswer.ToUpper() == answer[x])
                        {
                            correct++;
                            incorrect--;
                        }
                        Console.Clear();
                    }
                }
                Console.WriteLine("Score: " + correct);
                Console.WriteLine("Missed: " + incorrect);
                Console.WriteLine("Congratulations on completing the quiz and taking a step towards the journey ahead of you!");
                Console.ReadKey();
            }
        }
    }
}

