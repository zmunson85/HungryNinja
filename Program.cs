using System;
using System.Collections.Generic; //  use this to allow 
namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            //object refference 
            var Zach = new Ninja();
            var menu = new Buffet();
            
            while(Zach.isFull != true)
            {
                var food= menu.Serve();
                Zach.Eat(menu.Serve());
            }
            Zach.Eat(menu.Serve());
        }
        class Food
        {
            //Fields
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy;
            public bool IsSweet;
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            // runs when we create a new instance.
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
                    return Menu[rand.Next(Menu.Count)];
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
                //derived from call intake eaten by ninja
                get
                {
                    if (calorieIntake > 3200)
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
                if (isFull)
                {
                    Console.WriteLine("THIS NINJA IS GONNA POP");
                }

                    else
                    {
                        Console.WriteLine(calorieIntake);
                        FoodHistory.Add(item);
                        Console.WriteLine($"Eating... {item.Name}");
                        calorieIntake += item.Calories;
                        Console.WriteLine(calorieIntake);
                        Console.WriteLine($"Buffet Item: {item.Name},\n Item spicy: {item.IsSpicy},\n Item Sweet: {item.IsSweet}");
                    }
            }
        }
    }

}