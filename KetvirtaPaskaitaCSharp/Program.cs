namespace LearningObjects
{

    public class Program
    {
        static void Main(string[] args)
        {
            /* Task 1*/
            int suma1 = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                //if (suma >= 100) { continue; }
                suma1 += i;
                Console.WriteLine(suma1);
            }

            Console.WriteLine("////////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////////");

            /* Task 2*/
            for (int i = 1; i <= 50; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " yra pirminis skaičius");
                }
            }

            /* Task 3*/
            for(int i = 1;i <= 50;i++) {
                if (ThreesAndFives(i) == 0)
                {
                    continue;
                }
                Console.WriteLine(ThreesAndFives(i));
            }



        }

        /* Task 2*/
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /* Task 3*/
        public static int ThreesAndFives(int num)
        {
            if (num % 3 == 0 || num % 5 == 0)
            {
                return num;
            }
            return 0;
        }
    }
}