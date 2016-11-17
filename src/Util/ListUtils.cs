using System;
using System.Collections.Generic;

namespace hhs_p6_cs_programming.Util {
    public static class ListUtils {

        /// <summary>
        /// Random object.
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Shuffle a list.
        /// </summary>
        /// <param name="list">List to shuffle.</param>
        /// <typeparam name="T">List type.</typeparam>
        public static void Shuffle<T>(this IList<T> list)  {
            // List size
            int n = list.Count;

            // Shuffle using Fisher-Yates algorithm
            while (n > 1) {
                n--;
                int k = rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}