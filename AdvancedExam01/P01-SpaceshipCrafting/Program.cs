using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chemicalsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] itemsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> chemicalLiquids = new Stack<int>(chemicalsInput);
            Queue<int> phisycalItems = new Queue<int>(itemsInput);

            int sumOfItems = 0;

            int glass = 25;
            int aluminium = 50;
            int lithium = 75;
            int carbonFiber = 100;

            while (chemicalLiquids.Count >0 || phisycalItems.Count > 0)
            {
                int currentLiquid = chemicalLiquids.Peek();
                
                int currentItem = phisycalItems.Peek();

                sumOfItems = currentLiquid + currentItem;

                if (sumOfItems == 25 || sumOfItems == 50 || sumOfItems == 75 || sumOfItems == 100)
                {
                    chemicalLiquids.Pop();
                    phisycalItems.Dequeue();

                }
                else
                {
                    chemicalLiquids.Pop();
                    currentItem += 3;
                }
            }
        }
    }
}
