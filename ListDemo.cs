using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_algo
{
    public class Customer
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

    }
    public class ListDemo
    {
        public static void Run()
        {
            List<int> list= new List<int>();
            LogCountAndCapacity(list);
            for (int i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }

            for (int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }

            list.TrimExcess();
            LogCountAndCapacity(list);

            list.Add(1);
            LogCountAndCapacity(list);

        }

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count is: {list.Count}. Capacity is: {list.Capacity}");
        }

        public static void ApiMembers()
        {
            List<int> list = new List<int>() { 1, 0, 5, 3, 4 };
            list.Sort();

            int indexBinSearch = list.BinarySearch(3);//for binary search;
            list.Reverse(); // it reverse the list, DOES NOT PERFORM AN DESCENDING SORT!!!!

            ReadOnlyCollection<int> readonlyList = list.AsReadOnly();// returns the list as a readonly, meaning that you wont be able to perform any changes to it;
            int[] arr = list.ToArray(); //returns the array of the list;


            var listCustomers = new List<Customer>()
            {
                new Customer{BirthDate = new DateTime(1988,08,12), Name = "Elias"},
                new Customer{BirthDate = new DateTime(1990,06,09), Name = "Maria"},
                new Customer{BirthDate = new DateTime(2015,06,09), Name = "Ann"}
            };

            listCustomers.Sort((left, right) =>
            {
                if (left.BirthDate > right.BirthDate)
                    return 1;
                if (right.BirthDate > left.BirthDate)
                    return -1;
                return 0;
            });



        }
    }
}
