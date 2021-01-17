using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("But I'm not always that way.");

            QuestionMoose("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            QuestionMoose("Are you enthusiastic?", "Yay!", "You should try it!");
            QuestionMoose("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            QuestionMoose("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
        }

        static void QuestionMoose(string question, string yesResponse, string noResponse)
        {
            bool isTrue = MooseAsks(question);
            if (isTrue)
            {
                MooseSays(yesResponse);
            }
            else {
                MooseSays(noResponse);
            }
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static bool MooseAsks(string question) 
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }
}