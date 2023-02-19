using static System.Console;

namespace MyPowerLib
{
    public class Power
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
        public static double Power(double number, double number1) {
            double pow;
            Power = Math.Pow(number, number1);

            Console.WriteLine(number + " to the power of " + number1 + " is " + pow);
            return pow;
        }
    }
}