using System;
using System.Collections.Generic;


namespace Hungry_Ninja
{

    class Food
    {
        public string Name;
        public int Calories;

        public bool IsSpicy;

        public bool Isweet;

    
        public Food(string name, int cal, bool spicy,bool sweet)
        {

                Name = name;
                Calories = cal;
                IsSpicy = spicy;
                Isweet = sweet;


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
            new Food("cheese", 1000, false, false),
            new Food("steak", 600, false, false),
            new Food("Eggs", 300, false, false),
            new Food("eggplant", 200, false, false),
            new Food("avocado", 100, false, false),
            new Food("shrimp", 40, false, false),
            new Food("almonds", 300, false, false),
        };
    }
     
    public Food Serve()
    {
        var random = new Random();
        int index = random.Next(Menu.Count);
        return Menu[index];
    }
}
class Ninja
{
    string Name = "The ninja-master";//set property string to Name
    private int calIntake;//set poperty int to calintake
    public List<Food> FoodHistory;
     
    // add a constructor
    public Ninja(string name){//constructor ninja
        Name = name;
        calIntake = 0;
        FoodHistory = new List<Food>();//makes a food history list

    }
     
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
           get
        {
            if(calIntake>1200)
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
        if (IsFull)
        {

            Console.WriteLine($"ninja {Name} is full and cant eat!");
        }
        else
        {
            calIntake += item.Calories;
            FoodHistory.Add(item);
            if (item.IsSpicy)
                {
                    Console.WriteLine($"the {item.Name} is way to spicy");
                }

            else if (item.Isweet)
                {
                    Console.WriteLine($"the {item.Name} is a little to sweet");
                }

            else
                {
                    Console.WriteLine($"the {item.Name} is so good you are a genius");
                }

        }
     
    }
}









    class Program
    {
        static void Main(string[] args)
        {
             Ninja joe = new Ninja("joe");
             Buffet GrandNinjaBuffet = new Buffet();
             joe.Eat(GrandNinjaBuffet.Serve());
             joe.Eat(GrandNinjaBuffet.Serve());
             joe.Eat(GrandNinjaBuffet.Serve());
             joe.Eat(GrandNinjaBuffet.Serve());
             joe.Eat(GrandNinjaBuffet.Serve());
             joe.Eat(GrandNinjaBuffet.Serve());
             joe.Eat(GrandNinjaBuffet.Serve());
        }
    }
}
