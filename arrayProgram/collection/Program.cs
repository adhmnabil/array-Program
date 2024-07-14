using System.Linq;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() ;
            char userInput = ' ';
            do
            {
                Console.WriteLine("kindly choose what you need to do :\r\n    P - Print numbers\r\n    A - Add a number\r\n    M - Display mean of the numbers\r\n    S - Display the smallest number\r\n    L - Display the largest number\r\n    C - CLear the list\r\n    f - Find the index of the number\r\n    i - find number by index\r\n    Q - Quit ");
                userInput = char.Parse(Console.ReadLine());
                if (userInput == 'p')
                {
                    if (list.Count > 0)
                    {
                       
                        string data = string.Join(" ", list);
                        Console.WriteLine($"[ {data} ]");
                    }
                    else
                    {
                        Console.WriteLine("List is empty");
                    }

                }

                if (userInput == 'a')
                {
                    Console.WriteLine("Kinndly add the number you need to add");
                    int input = int.Parse(Console.ReadLine());
                    bool duplicate = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if(list[i] == input)
                        {
                            duplicate = true;
                        }
                    }
                    if (duplicate)
                    {
                        Console.WriteLine("sorry the number is in the application and you can not add it");
                    }
                    else
                    {
                    list.Add(input);
                    }
                    Console.WriteLine("number added!");
                }


                if(userInput == 's'|| userInput == 'l' || userInput == 'm' || userInput == 'c' || userInput == 'f' || userInput == 'i')
                {
                    if(list.Count > 0)
                    {
                        if (userInput == 's')
                        {


                            double smallest = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] < smallest)
                                {
                                    smallest = list[i];
                                }
                            }
                            Console.WriteLine(smallest);

                        }

                        if (userInput == 'l')
                        {

                            double largest = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > largest)
                                {
                                    largest = list[i];
                                }
                            }
                            Console.WriteLine(largest);

                        }
                        if (userInput == 'm')
                        {

                            double result = 0;
                            for (int i = 0; i < list.Count; i++)
                            {
                                result += list[i];
                            }
                            Console.WriteLine(result);

                        }
                        if (userInput == 'c')
                        {
                            list.Clear();
                            Console.WriteLine("list is empty now thanks!");
                        }
                        if (userInput == 'f')
                        {
                            double numberToFind = int.Parse(Console.ReadLine());
                            for (int i = 0; i < list.Count; i++)
                            {
                                if(list[i] == numberToFind)
                                    {
                                    Console.WriteLine($"index number is {i}");
                                }
                                else
                                {
                                    Console.WriteLine("number not found sorry");
                                }
                            }
                        }
                        if (userInput == 'i')
                        {
                            Console.WriteLine("enter the index number");
                            int index = int.Parse(Console.ReadLine());
                            if (index < list.Count)
                            {
                                Console.WriteLine("Here is ur number : ");
                                Console.WriteLine(list[index]);
                            }
                            else
                            {
                                Console.WriteLine("Sorry list is shorter");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("List is empty");
                    }
                }

           

            } while (userInput != 'q');
            {
                Console.WriteLine("Thank you for ur time!");
            };
        }
    }
}
