using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var tickets = input.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                string curr = tickets[i];

                if (!string.IsNullOrEmpty(curr))
                {
                    if (CheckForInvalidTicket(curr))
                    {
                        string pattern1 = @"([@]{6,})";
                        string pattern2 = @"([$]{6,})";
                        string pattern3 = @"([\^]{6,})";
                        string pattern4 = @"([#]{6,})";

                        if (CheckForWin(pattern1, curr) == -1 &&
                            CheckForWin(pattern2, curr) == -1 &&
                            CheckForWin(pattern3, curr) == -1 &&
                            CheckForWin(pattern4, curr) == -1)
                        {
                            Console.WriteLine($"ticket \"{curr}\" - no match");
                        }
                        else if (CheckForWin(pattern1, curr) > 0)
                        {
                            if (CheckForWin(pattern1, curr) == 10)
                            {
                                Console.WriteLine($"ticket \"{curr}\" - 10@ Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{curr}\" - {CheckForWin(pattern1, curr)}@");
                            }
                        }
                        else if (CheckForWin(pattern2, curr) > 0)
                        {
                            if (CheckForWin(pattern2, curr) == 10)
                            {
                                Console.WriteLine($"ticket \"{curr}\" - 10$ Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{curr}\" - {CheckForWin(pattern2, curr)}$");
                            }
                        }
                        else if (CheckForWin(pattern3, curr) > 0)
                        {
                            if (CheckForWin(pattern3, curr) == 10)
                            {
                                Console.WriteLine($"ticket \"{curr}\" - 10^ Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{curr}\" - {CheckForWin(pattern3, curr)}^");
                            }
                        }
                        else if (CheckForWin(pattern4, curr) > 0)
                        {
                            if (CheckForWin(pattern4, curr) == 10)
                            {
                                Console.WriteLine($"ticket \"{curr}\" - 10# Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{curr}\" - {CheckForWin(pattern4, curr)}#");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"invalid ticket");
                    }
                }
            }
        }

        private static int CheckForWin(string pattern, string curr)
        {
            string leftStr = curr.Substring(0, 10);
            string rightStr = curr.Substring(10);
            var regex = new Regex(pattern);
            var matchLeft = regex.Match(leftStr);
            var matchRight = regex.Match(rightStr);

            if (matchLeft.Success &&
                matchRight.Success)
            {
                if (matchLeft.Groups[1].Length <= matchRight.Groups[1].Length)
                {
                    return matchLeft.Groups[1].Value.Length;
                }
                else
                {
                    return matchRight.Groups[1].Length;
                }
            }
            else
            {
                return -1;
            }
        }

        private static bool CheckForInvalidTicket(string curr)
        {
            bool result = true;

            if (curr.Length == 20)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}

