namespace HW3_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class IenumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            //Check the collections, If the collections is empty, system throws exception;

            T result = collection.FirstOrDefault();

            foreach (var sum in collection.Skip(1))
            {
                result += (dynamic)sum;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)

        {
            T result = collection.FirstOrDefault();

            foreach (var sum in collection.Skip(1))
            {
                result += (dynamic)sum;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T result = collection.FirstOrDefault();

            foreach (var item in collection.Skip(1))
            {
                if (result.CompareTo(item)==1)
                {
                    result = item;
                }
            }
            return result;
        }
        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T result = collection.FirstOrDefault();

            foreach (var item in collection.Skip(1))
            {
                if (result.CompareTo(item)==-1)
                {
                    result = item;
                }
            }
            return result;
        }
        public static T Average<T>(this IEnumerable<T> collection)
        {
            T result = collection.FirstOrDefault();
            int count = 1;
            foreach (var item in collection.Skip(1))
            {
                result += (dynamic)item;
                count++;
            }

            return ((dynamic)result / count);
        
        }
    }
}
