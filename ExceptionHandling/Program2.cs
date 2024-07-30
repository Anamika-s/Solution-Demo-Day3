using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program2
    {
        static void Main()
        {
            int rn=0;
            string name = string.Empty;
            string batch = string.Empty;
            int score=0;
            try
            {
                Console.WriteLine("enter rn");
                rn = byte.Parse(Console.ReadLine());
                if (rn < 0 || rn > 20)
                    throw new CustomException("Rn can come in 1 to 20 range only");
                Console.WriteLine("enter name");
                name = Console.ReadLine();
                if (name.Length < 10)
                    throw new CustomException("MIn 10 chacracters needed");
                Console.WriteLine("enter batch");
                batch = Console.ReadLine();
                Console.WriteLine("enter score");
                score = byte.Parse(Console.ReadLine());
                if (score < 0 || score > 100)
                    throw new CustomException("Score can come in 0 to 100 range only");

            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("rn is " + rn);
                Console.WriteLine("name is " + name);
                Console.WriteLine("batch is " + batch);
                Console.WriteLine("score is " + score);
            }
        }
    }
}
