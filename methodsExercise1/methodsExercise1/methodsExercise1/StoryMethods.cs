using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise1
{
     class StoryMethods
    {
        public static void Name()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your excitement level about coding?");
            var excitement = Console.ReadLine();

            Console.WriteLine("What music do you listen to while coding?");
            var music = Console.ReadLine();

            Console.WriteLine("What will you gift to yourself upon landing the development job you desire?");
            var gift = Console.ReadLine();

            var story = $"{name}'s excitement level about coding is {excitement}.\n" +
                $"{name} listens to {music} while coding.\n" +
                $"When {name} lands their first job coding, {name} will gift themself: {gift}.\n" +
                $"Go TrueCoders!";

            Console.WriteLine($"{story}");
        }
    }
}
