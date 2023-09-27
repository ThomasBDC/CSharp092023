using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp092023
{
    public static class Methods
    {
        private static Random rnd = new Random();

        private static int getNumberAlea(int MAX)
        {
            return rnd.Next(0, MAX);
        }

        public static string GetRandomItemInTab(List<string> baseList)
        {
            int indexRandom = getNumberAlea(baseList.Count());
            string randomItem = baseList[indexRandom];
            return randomItem;
        }

        public static string GetRandomItemInTab(string[] baseArray)
        {
            int indexRandom = getNumberAlea(baseArray.Count());
            string randomItem = baseArray[indexRandom];
            return randomItem;
        }
    }
}
