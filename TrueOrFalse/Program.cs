using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            //store questions and answers in variable
            string[] questions = { "The sky is blue", "Berlioz is a cat", "spaghetti is a type of fruit" };

            bool[] answers = { true, true, false };

            bool[] responses = new bool[3];

            //create warning if user submits answer other than bool
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("WARNING: Questions and Answers do not have the same amount");
            }

            
            int askingIndex = 0;

            //loop through questions, take user input. 
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;

            }
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }
            //loop through answers, add to score and scoring index
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ". ");
                Console.WriteLine($"Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {scoringIndex} correct!");

        }
    }
}
