namespace LearningObjects
{

    public class Program
    {
        static void Main(string[] args)
        {
            /* Task 1*/
            Console.WriteLine("TASK 1");
            int suma1 = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                //if (suma >= 100) { continue; }
                suma1 += i;
                Console.WriteLine(suma1);
            }

            /* Task 2*/
            Console.WriteLine("TASK 2");
            for (int i = 1; i <= 50; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " yra pirminis skaičius");
                }
            }

            /* Task 3*/
            Console.WriteLine("TASK 3");
            for (int i = 1; i <= 50; i++)
            {
                if (ThreesAndFives(i) == 0)
                {
                    continue;
                }
                Console.WriteLine(ThreesAndFives(i));
            }

            /* Task 4*/
            Console.WriteLine("TASK 4");
            int highestNumber = 0;
            int[] masyvas = { 3, 5, 7, 2, 8 };
            foreach (int i in masyvas)
            {
                if (highestNumber <= i)
                {
                    highestNumber = i;
                }
                else { continue; }
            }
            Console.WriteLine("Highest number " + highestNumber);

            /* Task 5*/
            Console.WriteLine("TASK 5");
            int[] averageArray = { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine(ArrayAverage(averageArray));

            /* Task 6*/
            Console.WriteLine("TASK 6");
            int[] negativeNumCountArray = { -1, 2, -3, 4, -5, 4, -6 };
            Console.WriteLine(NegativeNumCount(negativeNumCountArray));

            /* Task 7*/
            Console.WriteLine("TASK 7");
            int[] masyvas2 = { 1, 2, 3, 4, 5 };
            CheckNumInArray(masyvas2, 6);
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

        /* Task 5*/
        public static int ArrayAverage(int[] array)
        {
            int arrNumCount = 0;
            int arrNumSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arrNumSum += array[i];
                arrNumCount++;
            }
            return arrNumSum / arrNumCount;
        }

        /* Task 6*/
        public static int NegativeNumCount(int[] array)
        {
            int numCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    numCount++;
                }
                else { continue; }
            }
            return numCount;
        }

        /* Task 7*/
        public static void CheckNumInArray(int[] array, int num)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine($"Skaičius {num} yra masyve");
                }
                else { continue; }
            }
            Console.WriteLine($"Skaičiaus {num} nėra masyve");

        }
    }
}