using System;
using System.Collections.Generic;
using System.Linq;

namespace HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Old Code

            //List<int> text = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    text.Add(i);
            //}

            //List<string> result = new List<string>();
            //foreach (int item in text)
            //{
            //    result.Add(item.ToString());
            //}

            #endregion Old Code

            List<int> text = Enumerable.Range(0, 10).ToList();
            List<string> result = text.Select(x => x.ToString()).ToList();
        }
    }
}