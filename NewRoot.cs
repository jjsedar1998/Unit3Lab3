using static System.Console;

namespace MyNewRootLib
{
    public class Root
    {
        /* <summary>
        /// this method calculates the root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>*/
        /*public static double MyRoot(double number) {
            double root;
            root = Math.Pow(number, 2);

            Console.WriteLine("The square root of " + number + " is " + root);
            return root;
        }*/
        public static double Power(double number) {
            double root;
            root = Math.Pow(number, 2);

            Console.WriteLine(number + " to the power of 2 is " + root);
            return root;
        }
    }
}