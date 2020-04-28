using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredientsValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var freshnessValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> ingredientValueQueue = new Queue<int>(ingredientsValues);
            Stack<int> freshnessValueStack = new Stack<int>(freshnessValues);

            Dictionary<string, int> cocktails = new Dictionary<string, int>();

            cocktails.Add("Mimosa", 0);
            cocktails.Add("Daiquiri", 0);
            cocktails.Add("Sunshine", 0);
            cocktails.Add("Mojito", 0);

            while (ingredientValueQueue.Count > 0 && freshnessValueStack.Count > 0)
            {
                int currentIngredient = ingredientValueQueue.Peek();
                int currentFreshness = freshnessValueStack.Peek();

                int currentCocktail = currentIngredient * currentFreshness;

                if (currentIngredient == 0)
                {
                    ingredientValueQueue.Dequeue();
                }
                else if (currentCocktail == 150)
                {
                    cocktails["Mimosa"]++;
                    ingredientValueQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else if (currentCocktail == 250)
                {
                    cocktails["Daiquiri"]++;
                    ingredientValueQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else if (currentCocktail == 300)
                {
                    cocktails["Sunshine"]++;
                    ingredientValueQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else if (currentCocktail == 400)
                {
                    cocktails["Mojito"]++;
                    ingredientValueQueue.Dequeue();
                    freshnessValueStack.Pop();
                }
                else
                {
                    freshnessValueStack.Pop();
                    int ingredientToIncrease = ingredientValueQueue.Dequeue();
                    ingredientValueQueue.Enqueue(ingredientToIncrease + 5);
                }
            }

            if (cocktails.Values.Sum() >= 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
                if (ingredientValueQueue.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredientValueQueue.Sum()}");
                }
                
                foreach (var item in cocktails.OrderBy(x => x.Key))
                {
                    if (item.Value >= 1)
                    {
                        Console.WriteLine($" # {item.Key} --> {item.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
                if (ingredientValueQueue.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredientValueQueue.Sum()}");
                }

                foreach (var item in cocktails.OrderBy(x => x.Key))
                {
                    if (item.Value >= 1)
                    {
                        Console.WriteLine($" # {item.Key} --> {item.Value}");
                    }
                }
            }
        }
    }
}
