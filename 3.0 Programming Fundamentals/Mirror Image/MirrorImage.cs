using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror_Image
{
    class MirrorImage
    {
        static List<string> list;
        static List<string> leftStrings;
        static List<string> rightStrings;
        static void Main(string[] args)
        {
            list = Console.ReadLine().Split(' ').ToList();
            string position = Console.ReadLine();
            int index = 0;
            leftStrings = new List<string>();
            rightStrings = new List<string>();
            string midElement = string.Empty;
            int size = list.Count;

            while (position != "Print")
            {
                index = int.Parse(position);
                leftStrings = new List<string>();
                rightStrings = new List<string>();
                midElement = list[index];
                if (index != 0)
                {
                    leftStrings = LeftStrings(index);
                }

                if (index != list.Count - 1)
                {
                    rightStrings = RightStrings(index);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    list.RemoveAt(i);
                    i--;
                }

                for (int i = 0; i <= index - 1; i++)
                {
                    list.Insert(i, leftStrings[i]);
                }
                list.Insert(index, midElement);
                for (int i = index + 1; i < size; i++)
                {
                    list.Insert(i, rightStrings[i - index - 1]);
                }
                position = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }

        static List<string> LeftStrings(int index)
        {
            string lastElement = String.Empty;
            for (int i = 0; i < index - 1; i++)
            {
                string temp = list[i];
                if (list[i] == list[index - 1 - i])
                {
                    break;
                }
                if (list[i] == lastElement || list[index - 1- i] == lastElement)
                {
                    break;
                }
                list[i] = list[index - 1 - i];
                lastElement = list[i];
                list[index - 1 - i] = temp;
            }

            for (int i = 0; i <= index - 1; i++)
            {
                leftStrings.Add(list[i]);
            }

            return leftStrings;
        }

        static List<string> RightStrings(int index)
        {
            int start = index + 1;
            int end = list.Count - 1;
            int counter = 0;
            string lastElement = String.Empty;
            for (int i = start; i <= end; i++)
            {
                string temp = list[i];
                if (list[i] == list[end - counter])
                {
                    break;
                }
                if (list[i] == lastElement || list[end - counter] == lastElement)
                {
                    break;
                }
                list[i] = list[end - counter];
                lastElement = list[i];
                list[end - counter] = temp;
                counter++;
            }

            for (int i = start; i <= end; i++)
            {
                rightStrings.Add(list[i]);
            }

            return rightStrings;
        }
    }
}
