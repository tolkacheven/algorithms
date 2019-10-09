using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigInteger;

namespace Tests
{
    class Program
    {

        /* Input format 
         * 
         *                     Strings

        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string [stringsCount];

        for (int i = 0; i < stringsCount; i++) {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }


        */



        static void Main(string[] args)
        {


            //CBigInteger test1 = new CBigInteger("1111101000", 'b');
            //CBigInteger test2 = new CBigInteger("1111101000", 'b');

            //CBigInteger test4 = test2 * 1000;

            //test4.Display();

            //Console.ReadKey();

            int? a = null;
            int? b = null;

            b = a++ == ++b ? a ?? 10 : 5;
            Console.WriteLine(b);
            Console.ReadKey();
        }


        private static void MyMethod(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        // Sparse Arrays
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] result = new int[queries.Length];
            int inx = 0;

            foreach (string word in queries)
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    if (word == strings[i])
                        result[inx]++;
                }
                inx++;
            } 


            return result;

        }



        /* Project Euler #20: Factorial digit sum */

        static ulong FactDigitSum(ulong n)
        {
            return PowerDigitNum(Factorial(n));
        }

        // Вычисление факториала
        static ulong Factorial(ulong x)
        {
            return (x == 0) ? 1 : x * Factorial(x - 1);
        }

        // Вычисление суммы цифр в числе n
        static ulong PowerDigitNum(ulong n)
        {
            ulong result = 0;
            ulong tmp = n;

            while (tmp > 0)
            {
                result += tmp % 10;
                tmp /= 10;
            }

            return result;
        }



        // Вычисление суммы цифр в числе 2^n
        static ulong PowerDigit(ulong n)
        {
            ulong result = 0;
            ulong tmp = (ulong) Math.Pow(2, n);

            while (tmp > 0)
            {
                result += tmp % 10;
                tmp /= 10;
            }
            
            return result;
        }

        

        // Find digits
        static int findDigits(int n)
        {
            int result = 0;
            int nCopy = n;

            while (nCopy > 0)
            {

                if (nCopy % 10 == 0)
                {
                    nCopy /= 10;
                    continue;
                }

                if (n % (nCopy % 10) == 0)
                    result++;
                
                nCopy /= 10;
            }
            
            return result;
        }



        // Cat and Mouse
        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(z - x) == Math.Abs(z - y)) return "Mouse C";
            return Math.Abs(z - x) > Math.Abs(z - y) ? "Cat B" : "Cat A";
        }



        // Electronics Shop
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int result = -1;
            int tmp_i;

            for (int i = 0; i < keyboards.Length; i++)
            {
                tmp_i = keyboards[i];
                for (int j = 0; j < drives.Length; j++)
                {
                    if (((tmp_i + drives[j]) <= b) && ((tmp_i + drives[j]) > result))
                    {
                        result = tmp_i + drives[j];
                    }
                }
            }

            return result;

        }



        // 2D Array - DS
        static int hourglassSum(int[,] arr)
        {
            int max = arr[0, 0] + arr[0, 1] + arr[0, 2] + arr[1, 1] + arr[2, 2] + arr[2, 1] + arr[2, 2];
            int tmp;
            
            for (int i = 0; i < arr.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < arr.GetLength(0) - 2; j++)
                {
                    tmp = arr[i, j] + arr[i, j + 1] + arr[i, j + 2] + arr[i + 1, j + 1] + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];

                    if (tmp > max)
                        max = tmp;

                    tmp = 0;
                }
            }

            return max;
        }



        // Repeated String
        public static long repeatedString(string s, long n)
        {
            return (n / s.Length) * s.Count(symbol => symbol == 'a') + s.Substring(0, (int)(n - (n / s.Length) * s.Length)).Count(symbol => symbol == 'a');
        }



        // Equalize the Array
        static int equalizeArray(int[] arr)
        {
            // var CntElm = new Hashtable();

            for (int i = 0; i < arr.Length; i++)
            {
                // CntElm.Add(arr.[i], ++);
            }

            return 0;
        }



        // Jumping on the Clouds
        static int jumpingOnClouds(int[] c)
        {
            int count = 0;
            int i = 0;
            int n = c.Length;

            while (i < n - 1)
            {
                if (i < n - 2 && c[i + 2] == 0)
                {
                    i++;
                }
                if (i != n - 1)
                {
                    count++;
                }
                i++;
            }

            return count;
        }



        static void extraLongFactorials(int n)
        {
            ulong result = 1;

            for (ulong digit = (ulong)n; digit > 0; digit--) result *= digit;

            Console.WriteLine(result);

        }


        // Project Euler #14: Longest Collatz sequence
        static int CollatzSequence(int n)
        {
            int max = CollatzSequenceCount(n);
            int maxInx = n;
            int tmp;

            while (--n > 0)
            {
                tmp = CollatzSequenceCount(n);
                if (tmp > max)
                {
                    max = tmp;
                    maxInx = n;
                }
            }

            return maxInx;
        }

        static int CollatzSequenceCount(int num)
        {
            int count = 0;

            while (num != 1)
            {
                if ((num & 1) != 0)
                    num = 3 * num + 1;
                else
                    num >>= 1;

                count++;
            }

            return count;
        }



        // Largest product in a series (ProjectEuler+ 8)
        /* 3675356291 10 5 -> 3150 */

        static int LargestProduct(string num, int n, int k)
        {
            foreach (char digit in num)
                if (digit == '0')
                    return 0;

            string currentDigitTypeString = num.Substring(0, k - 1);
            int    currentDigitTypeInt = 1, biggestDigit = 0;
            
            for (int i = k - 1; i < n; i++)
            {
                currentDigitTypeString += num[i];

                foreach (char digit in currentDigitTypeString)
                    currentDigitTypeInt *= Convert.ToInt32(digit) % 48;


                if (currentDigitTypeInt > biggestDigit)
                    biggestDigit = currentDigitTypeInt;

                currentDigitTypeInt = 1;

                currentDigitTypeString = currentDigitTypeString.Substring(1, k - 1);;
            }
          
            return biggestDigit;
        }





        /* Printing matrix like
         * 3 3 3 3 3
         * 3 2 2 2 3
         * 3 2 1 2 3
         * 3 2 2 2 3
         * 3 3 3 3 3
         * */

        static void PrintPattern(int n)
        {
            int matrixSize = (n * 2) - 1;

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int start = 0, end = matrixSize - 1, number = n; start <= end; start++, end--, number--)
            {
                for (int i = start; i <= end; i++)
                {
                    matrix[start, i] = number;          // Заполнение горизонтальных
                    matrix[end, i] = number;            //          ребер

                    matrix[i, start] = number;          // Заполнение вертикальных
                    matrix[i, end] = number;            //          ребер
                }
            }

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }


        /*
         * Project Euler #9: Special Pythagorean triplet
         * https://www.hackerrank.com/contests/projecteuler/challenges/euler009
            a = u* v
            b = (u^2 - v^2)/2
            c = (u^2 + v^2)/2   */
          
        static int Pythagorean (int n)
        {
            int result = 0;
            //int a = 0, b = 0, c = 0;
            


            return result;
        }
            
            
        // Summation of Primes (Project Euler 10) : 
        static int SummationOfPrimes(int n)
        {
            int result = 0;

            n++;

            int[] primes = new int[n + 1];


            if (n <= 1)
                return 0;


            for (int i = 0; i < n; i++)
                primes[i] = i;


            for (int i = 2; i < Math.Sqrt(n); i++)
                if (primes[i] != 0)
                    for (int k = i * i; k < n; k += i)
                        primes[k] = 0;


            for (int i = 2; i <= n; i++)
                Console.Write(primes[i] + " ");

            Console.WriteLine();


            for (int i = 2; i <= n; i++)
                result += primes[i];


            return result;
        }
        



        // 10001st prime number (решето Эратосфена)
        static int NstPrime(int n)
        {
            int result = 0;

            int[] numbers = new int[n];

            for (int i = 0; i <= n; i++)
                numbers[i] = i;

            //for (int i = 2; i <= Math.Sqrt(n); i)

            return result;
        }



        // Drawing Book
        static int pageCount(int n, int p)
        {
            return ((n / 2 - p / 2) < (p / 2) ? (n / 2 - p / 2) : (p / 2));

        }

        

        // Sock Merchant
        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0, cntSck = 0;
            
            HashSet<int> socks = new HashSet<int>();

            for (int i = 0; i < ar.Length; i++)
                socks.Add(ar[i]);

            foreach (int sock in socks) {
                cntSck = 0;
                for (int i = 0; i < n; i++)
                {
                    if (ar[i] == sock)
                        cntSck++;
                }

                pairs += cntSck / 2;
            }

            return pairs;

        }



        // Day of programmer

        /****         ТЕСТЫ         ****

          Input               Output 
          1917              13.09.1917 
          1915              13.09.1915 
          1800              12.09.1800 

         *******************************/
        static string dayOfProgrammer(int year)
        {
            List<int> daysInMonth = new List<int>() { 31, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                                                                                   // Количество дней в месяце. На позицию [1] будет добавлено число 28 (29) в зависимости от високосности;
            //List<int> julianDifference = new List<int>() { 11, 12, 13 };         // Разница между Юлианским и Григорианским календарями;

            int currentDay = 0;
            int resultDay = 256;                                                   // Переменная, которая в результате вычисления resultDay - currentDay будет хранить количетсво дней, недостающих до 256;

            bool leap = false;                                                     // leap = false - год невисокосный, true - високосный;
            string result = "";                                                    // Конечный результат в формате dd.mm.yyyy;
                        

            // Проверка: високосный ли год?
            if ((year % 400) == 0)
                leap = true;
            else if (((year % 100) == 0) && (year >= 1919))
                leap = false;
            else if ((year % 4) == 0)
                leap = true;
            else
                leap = false;


            // Добавляем в список daysInMonth 28 (29) дней февраля в зависимости от того, високосный ли год
            if (leap)
                daysInMonth.Insert(1, 29);
            else
                daysInMonth.Insert(1, 28);


            // Григорианский календарь. Считаем принятым с 1919 года
                int i = 0;
                while((currentDay + daysInMonth[i]) < 256)
                {
                    currentDay += daysInMonth[i];
                    i++;
                }

                resultDay -= currentDay;
                if (year == 1918)
                {
                    resultDay += 13;
                }

                if (resultDay < 10)
                {
                    result += "0" + Convert.ToString(resultDay) + ".";
                } else
                {
                    result += Convert.ToString(resultDay) + ".";
                }

                if ((i + 1) < 10)
                {
                    result += "0" + Convert.ToString(i + 1) + ".";
                } else
                {
                    result += Convert.ToString(i + 1) + ".";
                }
            
            result += Convert.ToString(year);
            
            return result;
        }



        // Between Two Sets
        static int getTotalX(int[] a, int[] b)
        {
            int from = a[a.Length - 1];
            int step = a[a.Length - 1];

            int to;
            int count = 0;
            int flag_isOkay = 1;

            if (b.Length == 1)
            {                
                to = b[0];
                if (to / from < 2)
                {
                    return 0;
                }
            } else
            {
                to = ((b[1] / b[0]) > 1 ? b[0] : b[0] / 2);
            }

            Console.WriteLine($"from {from}, to {to}, step {step}");
            
            for (int i = from; i <= to; i += step)
            {
                Console.WriteLine($"Рассматривается число {i}");
                flag_isOkay = 1;
                for (int j = 0; j < a.Length; j++)
                {
                    if (i % a[j] == 0)
                    {
                        continue;
                    } else
                    {
                        flag_isOkay = 0;
                    }

                    if (flag_isOkay == 0)
                        break;
                }

                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] % i == 0)
                    {
                        continue;
                    }
                    else
                    {
                        flag_isOkay = 0;
                        break;
                    }
                }

                if (flag_isOkay == 1)
                {
                    Console.WriteLine($"Найдено число: {i}");
                
                    count++;
                }
            }

            return count;
        }



        // TIme Conversion
        static string timeConversion(string s)
        {
            string resultString = s;
            string tmp = resultString.Substring(resultString.Length - 2);

            if ((tmp == "AM") && (Convert.ToInt32(resultString.Substring(0, 2)) == 12))
            {
                resultString = resultString.Remove(0, 2);
                resultString = resultString.Insert(0, "00");
            }

            if (tmp == "PM")
            {
                int curHour = Convert.ToInt32(resultString.Substring(0, 2)) + 12;
                resultString = resultString.Remove(0, 2);

                if (curHour == 24)
                    resultString = resultString.Insert(0, "12");
                else
                    resultString = resultString.Insert(0, Convert.ToString(curHour));
                
            }

            resultString = resultString.Remove(resultString.Length - 2);

            return resultString;
        }


      
        // Bon Appetit
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int AnnaPortion = 0;
            int b_actual, b_total = 0;

            for (int i = 0; i < bill.Count; i++)
                AnnaPortion += bill[i];
            AnnaPortion -= bill[k];

            b_actual = AnnaPortion / 2;
            b_total = b - b_actual;

            if ((b == b_total) || (b_total == 0))
            {
                Console.WriteLine("Bon Appetit");
            } else
            {
                Console.WriteLine(b_total);
            }                       
        }



        // Migratory birds
        static int migratoryBirds(List<int> arr)
        {
            List<int> totalCounts = new List<int>() { 0, 0, 0, 0, 0 };

            for (int i = 0; i < arr.Count; i++)
                totalCounts[arr[i] - 1]++;

            int maxVal = 0, ID = 0;
            for (int i = 0; i < 5; i++)
                if (totalCounts[i] > maxVal)
                {
                    ID = i + 1;
                    maxVal = totalCounts[i];
                }

            return ID;
        }



        // Divisible sum pairs
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int result = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        result++;
                }
            }

            return result;
        }



        // Birthday chocolate
        static int birthday(List<int> s, int d, int m)
        {
            // m - number of chocolate squares;
            // d - total sum of squares;

            int result = 0;
            int tmpres = 0;

            if (m == 1)
            {
                for (int i = 0; i < s.Count; i++)
                {
                    if (s[i] == d)
                    {
                        result++;
                    }
                }

                return result;
            }

            for (int i = 0; i < s.Count - m + 1; i++)
            {
                tmpres = 0;
                for (int j = 0; j < m; j++)
                {
                    tmpres += s[i + j];
                }

                if (tmpres == d)
                    result++;
                else
                    continue;
            }
            return result;
        }



        // Breaking the records
        static void breakingRecords(int[] scores)
        {
            int numOfMaximum = 0, numOfMinimum = 0;
            int currentMax = scores[0], currentMin = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > currentMax)
                {
                    currentMax = scores[i];
                    numOfMaximum++;
                }
                else if (scores[i] < currentMin)
                {
                    currentMin = scores[i];
                    numOfMinimum++;
                }
                else continue;
            }
            Console.WriteLine($"{numOfMaximum} {numOfMinimum}");
        }



        // Наименьшее кратное чисел от 1 до N
        static int lcmOfSequence(int n)
        {
            int currentLCM = 1, previousLCM = 1;

            for (int i = 2; i <= n; i++)
            {
                currentLCM = lcm(previousLCM, i);
                previousLCM = currentLCM;
            }
            return currentLCM;
        }


        
        // Наибольший простой делитель
        static int maxSimpleDivider(int n)
        {
            int divider = 1;
            int d = 2;

            while (d < n)
                if (n % d == 0)
                {
                    divider = d;
                    n /= d;
                }
                else
                    ++d;

            if (n != 1)
                divider = n;

            return divider;
        }



        // Наибольший общий делитель, алгоритм Евклида (НОД)
        static int gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }



        // Наименьшее общее кратное (НОК)
        static int lcm(int a, int b)
        {
            return ((a * b) / gcd(a, b));
        }
    }

}
