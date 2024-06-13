/*User wants to add an element in the list:
	-Ask for a position (index) to insert at in the list
    - If the input is null, add at last, else at the given position*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace user
{

    class User
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 10, 20, 30, 40, 50 };
            list1.Capacity = 10;
            while (true)
            {
                Console.WriteLine("Enter your wish \n 1 - For Adding element \n 2 - Removing element based on index \n 3 - Removing element based on value: ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("Enter the value you want to insert : ");
                    try
                    {
                        int v = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Index at which you want to add : ");
                        var index1 = Console.ReadLine();
                        if (string.IsNullOrEmpty(index1))
                        {
                            list1.Add(v);
                            ListElements(list1);
                        }
                        else
                        {
                            int index = Convert.ToInt32(index1);
                            try
                            {
                                    list1.Insert(index, v);
                                    ListElements(list1);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Index Out of Bound");
                            }
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter the value of index !");
                    }

                }
                else if (i == 2)
                {
                    Console.WriteLine("Enter the Index at which you want to remove : ");
                    try
                    {
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        list1.RemoveAt(n1);
                        ListElements(list1);
                    }
                    catch (Exception)
                    {
                        // value is null so remove last element from list 
                        list1.RemoveAt(list1.Count);
                        ListElements(list1);
                    }

                }
                else if (i == 3)
                {
                    Console.WriteLine("Enter the Value of the element you want to remove : ");
                    try
                    {
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        if (n2 == list1[i])
                        {
                            //Console.WriteLine("Please enter the elements value");
                            list1.RemoveAt(n2);
                            ListElements(list1);
                        }
                        else
                        {
                            Console.WriteLine("The Value is not present");
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter the elements value");
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter correct value");
                }

            }

        }

        private static void ListElements(List<int> list1)
        {
            // printing the full list 
            Console.WriteLine("The list is :");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
