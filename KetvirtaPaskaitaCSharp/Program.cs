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

            /* Task 8*/
            Console.WriteLine("TASK 8");
            int[] simpleArray = { 1, 2, 3, 4, 5 };
            int[] reverseArray = new int[simpleArray.Length];
            int index = 0;
            for (int i = simpleArray.Length - 1; i >= 0; i--)
            {
                reverseArray[index++] = simpleArray[i];
            }
            for (int i = 0; i <= reverseArray.Length - 1; i++)
            {
                Console.WriteLine(reverseArray[i]);
            }

            /* Task 9*/
            Console.WriteLine("TASK 9");
            int[] masyvas3 = { 1, 2, 2, 3, 4, 4, 5 };
            int[] masyvas4 = new int[6];
            for (int ix = 0; ix <= masyvas3.Length - 1; ix++)
            {
                masyvas4[masyvas3[ix]]++;
            }
            for (int i = 0; i <= masyvas4.Length - 1; i++)
            {
                if (masyvas4[i] > 1)
                {
                    Console.WriteLine(i);
                }
            }

            /* Task 10*/
            Console.WriteLine("TASK 10");
            int[] masyvas5 = { 1, 2, -3, 4, -5 };
            int firstNegative = 0;
            for (int i = 0; i <= masyvas5.Length; i++)
            {
                if (masyvas5[i] < 0)
                {
                    firstNegative = masyvas5[i];
                    break;
                }
            }
            Console.WriteLine(firstNegative);

            /* Task 11*/
            Console.WriteLine("TASK 11");
            int[] masyvas6 = { 1, 2, 3, 4, 5, 6 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < masyvas6.Length; i++)
            {
                if (masyvas6[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

            }
            Console.WriteLine($"There are {even} even and {odd} odd numbers in this array");

            /* Task 12*/
            Console.WriteLine("TASK 12");
            int[] masyvas7 = { 3, 5, 7, 2, 8, -1, 4 };
            int highestNum = 0;
            int lowestNum = 0;
            int num = 0;
            while (num < masyvas7.Length)
            {
                if (highestNum < masyvas7[num])
                {
                    highestNum = masyvas7[num];
                }

                if (lowestNum > masyvas7[num])
                {
                    lowestNum = masyvas7[num];
                }

                num++;
            }
            Console.WriteLine($"Highest number is {highestNum} and lowest number is {lowestNum}");

            /* Task 13*/
            Console.WriteLine("TASK 13");
            int[] masyvas8 = { 1, 3, 5, 7, 9, 11 };
            int arraySum = 0;
            for (int i = 0; i < masyvas8.Length; i++)
            {
                if (masyvas8[i] > 4 && masyvas8[i] < 10)
                {
                    arraySum += masyvas8[i];
                }
            }
            Console.WriteLine(arraySum);

            /* Task 14*/
            Console.WriteLine("TASK 14");
            int[] masyvas9 = { 1, 2, 2, 3, 4, 1, 5, 6 };
            int ii = 0;
            int num1 = 0;
            while (ii < masyvas9.Length) {
                break;
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