using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo, divisor;

            pedirParametros(out dividendo, out divisor);
            
            try
            {
                Console.WriteLine(dividendo + " / " + divisor + " = " + dividir(dividendo, divisor));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static int dividir(int dividendo, int divisor)
        {
            int cociente = 1;
            int nuevoDividendo = dividendo - divisor;
            if(divisor == 0)
            {
                throw new DivideByZeroException();
            }
            if(nuevoDividendo < 0)
            {
                return 0;
            } 
            else if(nuevoDividendo == 0)
            {
                return 1;
            }
            else
            {
                cociente += dividir(nuevoDividendo, divisor);
                return cociente;
            }

        }

        static void pedirParametros(out int dividendo, out int divisor)
        {
            Console.Write("Dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            divisor = int.Parse(Console.ReadLine());
        }
    }
}
