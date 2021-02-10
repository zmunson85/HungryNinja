using System;
using System.Collections.Generic;
namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {

            Ninja Zach = new Ninja();
            Buffet menu = new Buffet();
            Food item = menu.Serve();
            Zach.Eat(menu.Serve());
            Zach.Eat(menu.Serve());
        }
        class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy;
            public bool IsSweet;
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food(string foodName, int cals, bool spicy, bool sweet)
            {
                Name = foodName;
                Calories = cals;
                IsSpicy = spicy;
                IsSweet = sweet;
            }
        }
        class Buffet
        {
            public List<Food> Menu;

            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("tacos", 800, true, false),
                    new Food("burger", 1000, false, false),
                    new Food("salad", 300, false, true),
                    new Food("chickenNrice", 800, true, false),
                    new Food("fro-yo", 200, false, true),
                    new Food("beefNpasta", 800, true, false),
                    new Food("steakNeggs", 1300, false, false),
                };
            }

            public Food Serve()
            {
                {
                    var rand = new Random();
                    return Menu[rand.Next(0, Menu.Count)];
                }

            }
        }

        class Ninja
        {
            private int calorieIntake;
            public int callAmount;
            public List<Food> FoodHistory;

            public Ninja()
            // add a constructor
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }

            // add a public "getter" property called "IsFull"
            public bool isFull
            {
                get
                {
                    if (calorieIntake > 1200)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }


            // build out the Eat method
            public void Eat(Food item)
            {
                if (isFull == false)
                {
                    Console.WriteLine(calorieIntake);
                    FoodHistory.Add(item);
                    Console.WriteLine($"Eating... {item.Name}");
                    calorieIntake += item.Calories;
                    Console.WriteLine(calorieIntake);
                    Console.WriteLine($"Buffet Item: {item.Name},\n Item spicy: {item.IsSpicy},\n Item Sweet: {item.IsSweet}");
                }
                else
                {
                    Console.WriteLine("THIS NINJA IS GONNA POP");
                }
            }
        }

    }
}

