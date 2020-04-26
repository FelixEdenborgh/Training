using System;
using System.Threading.Channels;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] names = new string[2];
                string s = names[0];
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error");

                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Code is done");
            }
            

            /* string firstName = "John";
             string lastName = "Doe";
             string name = $"My full name is: {firstName} {lastName}";
             Console.WriteLine(name);*/


            // const float Pi = 3.14f;
            /*double x = 64;
            Console.WriteLine(Math.Sqrt(x));
            double y = 2.5;
            Console.WriteLine(Math.Round(y));*/

        }

    }
}


/*Range to store values from min to max
 *Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
 Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
 Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
 Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
 *
 *
 *
 */
