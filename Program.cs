using System;

namespace CivSem2ExceptionsExamples2021
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please enter an integer");
                var input = Console.ReadLine();
                
                try {
                    int num = int.Parse(input);

                    if(num < 0) {
                        throw new NegativeNumberException("Negative number was detected");
                    }

                    Console.WriteLine(num);

                } catch (FormatException x) {
                    Console.WriteLine("You entered an input that cannot be converted into an integer - " + e.Message);
                } catch (NegativeNumberException e) {
                    System.Console.WriteLine(e.Message);
                } catch (Exception e) {
                    Console.WriteLine("Something went wrong :( " + e.Message);
                } finally {
                    Console.WriteLine("Thanks for using this program, please come again!");
                }           
        }
    }

    class NegativeNumberException: Exception {
        public NegativeNumberException(): base("Negative number detected") {}
        public NegativeNumberException(string message): base(message) {}
    }
}
