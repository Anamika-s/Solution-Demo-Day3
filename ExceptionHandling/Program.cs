namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res = 0;
            try
            {
                Console.WriteLine("enter num ");
                num1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("enter den");
                num2 = byte.Parse(Console.ReadLine());
                res = num1 / num2;

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Only numbers are allowed");
            }
             catch(DivideByZeroException ex)
            {
                Console.WriteLine("cannot divide num by 0");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("NUm is outside the range");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Res is" + res);
                Console.WriteLine("END OF PROG");
            }
        }
    }
}
