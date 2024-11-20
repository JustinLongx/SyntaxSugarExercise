using System.Net.NetworkInformation;

namespace SyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Given the following code, change the code to implement:

            //+ inferred typing
            //+ string interpolation
            //+ and the ternary operator

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);

        }
    }
}
