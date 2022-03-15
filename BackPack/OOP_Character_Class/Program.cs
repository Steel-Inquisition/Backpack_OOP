using System;
using System.Collections.Generic;

namespace backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<backpackClass> backpack = new List<backpackClass>();

            backpack.Add(new backpackClass("blue", "small"));
            backpack.Add(new backpackClass("red", "medium"));
            backpack.Add(new backpackClass("green", "large"));

            backpack[0].openBag();
            backpack[0].putin("lunch");
            backpack[0].putin("jacket");
            backpack[0].closeBag();
            backpack[0].openBag();
            backpack[0].takeout("jacket");
            backpack[0].closeBag();

            for (int i = 0; i < backpack[0].items.Count; i++)
            {

            }
        }
    }

    public class backpackClass
    {

        public List<string> items = new List<string>();
        public string color;
        public string size;
        public bool open = false;

        public backpackClass(string getColor, string getSize)
        {
            this.color = getColor;
            this.size = getSize;
        }


        // Wouldn't it be better just to have one method that passes a bool?
        public void openBag()
        {
            if (this.open == false)
            {
                Console.WriteLine("The bag is opened!");
                this.open = true;
            } else
            {
                Console.WriteLine("This bag is already opened!");
            }

        }

        public void closeBag()
        {
            if (this.open == true)
            {
                Console.WriteLine("The bag is closed!");
                this.open = false;
            }
            else
            {
                Console.WriteLine("This bag is already closed!");
            }
        }

        public void putin(string item)
        {
            Console.WriteLine($"You placed in {item}!");
            items.Add(item);
        }

        public void takeout(string item)
        {
            Console.WriteLine($"You removed {item}!");
            items.Remove(item);
        }
    }
}
