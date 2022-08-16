using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Handler
{
    internal class SortHandler
    { 
        /**
         * Methode zum erkennen ob die Sortierung richtig ablief.
         * Parameter afterSort:
         * Eine liste nach sortierverfahren
         * 
         * Sortiert die Liste mit .Sort() und vergleicht diese miteinander ob diese genau gleich aussehen.
         **/
        private static bool TestSort(List<int> afterSort)
        {
            bool equal = true;

            List<int> sortedList = new List<int>();
            sortedList.AddRange(afterSort.GetRange(0, afterSort.Count));
            sortedList.Sort();

            int i = 0;
            while (i < afterSort.Count)
            {
                if (afterSort.ElementAt(i) != sortedList.ElementAt(i))
                {
                    equal = false;
                }
                i++;
            }

            return equal;
        }

        /**
         * Erzeugt eine Liste an Integern
         * parameter size:
         * gibt die Länge der zufällig generierten Liste an.
         * Der Wertebereich ist gleich lang wie die länge. 
         *  -> bei X Werten liegen alle Werte zwischen 0 und X
         **/
        private static List<int> generateRandomList(int size)
        {
            List<int> intList = new List<int>();
            int iIndex = 0;
            Random rnd = new Random(0);
            while (iIndex < size)
            {
                intList.Add(rnd.Next(size));
                iIndex++;
            }

            return intList;
        }

        /**
         * Generiert eine kleine Liste mit Zahlen von 1-9 unsortiert und gibt diese zurück.
         * Gut zum debuggen
         **/
        private static List<int> generateShortList()
        {
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(4);
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(2);
            list.Add(9);
            list.Add(8);
            list.Add(6);
            return list;
        }

        public static void mergeSortTest()
        {
            Console.WriteLine("Sortiert...");
            // Erstellen und Sortieren kleiner Liste
            List<int> sortableList = generateRandomList(100);
            sortableList = mergeSort(sortableList);

            // Prüfen ob beide Listen gleich aussehen
            if(!TestSort(sortableList))
            {
                Console.WriteLine("MergeSort Ergebnis nicht akzeptabel");
            } else
            {
                ListHandler.print(sortableList);
                Console.WriteLine("MergeSort erfolgreich durchgelaufen");
            }
        }

        public static List<int> mergeSort(List<int> paramList)
        {
            if (paramList == null)
                return new List<int>();
            if (paramList.Count <= 1)
                return paramList;

            int paramListSize = paramList.Count;
            int halfWay = paramListSize / 2;

            List<int> firstList = mergeSort(paramList.GetRange(0, halfWay));
            List<int> secondList = mergeSort(paramList.GetRange(halfWay, (paramListSize - halfWay)));

            List<int> resultList = new List<int>();
            while(firstList.Count != 0
                && secondList.Count != 0)
            {
                if(firstList.First() < secondList.First())
                {
                    resultList.Add(firstList.First());
                    firstList.RemoveAt(0);
                } else
                {
                    resultList.Add(secondList.First());
                    secondList.RemoveAt(0);
                }
            }

            if (firstList.Count != 0)
            {
                resultList.AddRange(firstList);
            } else
            {
                resultList.AddRange(secondList);
            }

            return resultList;
        }
    }
}
