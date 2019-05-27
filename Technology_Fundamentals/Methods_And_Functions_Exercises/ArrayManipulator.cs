using System;
using System.Numerics;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                var input = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "exchange")
                {
                    BigInteger index = BigInteger.Parse(input[1]);
                    int indexSmall = (int)index;

                    if (index >= 0 && index < arr.Length)
                    {
                        arr = GetExchange(arr, indexSmall);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (input[0] == "max")
                {
                    string number = input[1];

                    if (number == "odd")
                    {
                        int index = GetMaxOddIndex(arr);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (number == "even")
                    {
                        int index = GetMaxEvenIndex(arr);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (input[0] == "min")
                {
                    string number = input[1];

                    if (number == "odd")
                    {
                        int index = GetMinOddIndex(arr);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (number == "even")
                    {
                        int index = GetMinEvenIndex(arr);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (input[0] == "first")
                {
                    ulong count = ulong.Parse(input[1]);

                    if (count > (ulong)arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int smallCount = (int)count;
                        string str = input[2];

                        if (str == "even")
                        {
                            int[] result = GetEvens(arr);

                            if (smallCount > result.Length)
                            {
                                Console.WriteLine("[" + string.Join(", ", result) + "]");
                            }
                            else
                            {
                                Console.Write("[");

                                for (int i = 0; i < smallCount - 1; i++)
                                {
                                    Console.Write(result[i] + ", ");
                                }

                                Console.Write(result[smallCount - 1] + "]");
                                Console.WriteLine();
                            }
                        }
                        else if (str == "odd")
                        {
                            int[] result = GetOdds(arr);

                            if (smallCount > result.Length)
                            {
                                Console.WriteLine("[" + string.Join(", ", result) + "]");
                            }
                            else
                            {
                                Console.Write("[");

                                for (int i = 0; i < smallCount - 1; i++)
                                {
                                    Console.Write(result[i] + ", ");
                                }

                                Console.Write(result[smallCount - 1] + "]");
                                Console.WriteLine();
                            }
                        }
                    }
                }
                else if (input[0] == "last")
                {
                    ulong count = ulong.Parse(input[1]);

                    if (count > (ulong)arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int smallCount = (int)count;
                        string str = input[2];

                        if (str == "even")
                        {
                            int[] result = GetEvens(arr);

                            if (smallCount > result.Length)
                            {
                                Console.WriteLine("[" + string.Join(", ", result) + "]");
                            }
                            else
                            {
                                Console.Write("[");
                                for (int i = result.Length - smallCount; i < result.Length - 1; i++)
                                {
                                    Console.Write(result[i] + ", ");
                                }

                                Console.Write(result[result.Length - 1] + "]");
                                Console.WriteLine();
                            }

                        }
                        else if (str == "odd")
                        {
                            int[] result = GetOdds(arr);

                            if (smallCount > result.Length)
                            {
                                Console.WriteLine("[" + string.Join(", ", result) + "]");
                            }
                            else
                            {
                                Console.Write("[");

                                for (int i = result.Length - smallCount; i < result.Length - 1; i++)
                                {
                                    Console.Write(result[i] + ", ");
                                }

                                Console.Write(result[result.Length - 1] + "]");
                                Console.WriteLine();
                            }

                        }
                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        public static int[] GetOdds(int[] arr)
        {
            try
            {
                int[] result = arr.Where(x => x % 2 == 1).ToArray();
                return result;
            }
            catch
            {
                return new int[0];
            }
        }

        public static int[] GetEvens(int[] arr)
        {
            try
            {
                int[] result = arr.Where(x => x % 2 == 0).ToArray();
                return result;
            }
            catch
            {
                return new int[0];
            }
        }

        public static int GetMaxOddIndex(int[] arr)
        {
            int max = int.MinValue;
            int index = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        public static int GetMinOddIndex(int[] arr)
        {
            int min = int.MaxValue;
            int index = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        public static int GetMaxEvenIndex(int[] arr)
        {
            int max = int.MinValue;
            int index = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        public static int GetMinEvenIndex(int[] arr)
        {
            int min = int.MaxValue;
            int index = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        public static int[] GetExchange(int[] arr, int index)
        {
            int count = 0;
            int[] result = new int[arr.Length];

            for (int i = index + 1; i < arr.Length; i++)
            {
                result[count] = arr[i];
                count++;
            }

            for (int j = 0; j <= index; j++)
            {
                result[count] = arr[j];
                count++;
            }

            return result;
        }
    }
}
