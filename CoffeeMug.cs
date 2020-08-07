using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_concept
{
    public class CoffeeMug
    {
        private string color { get; set; }
        private string textColor { get; set; }
        private string phrase { get; set; }
        private int size { get; set; }
        private bool isFull { get; set; }

        public CoffeeMug(string whatColor, string whatTextColor, string whatPhrase, int whatSize)
        {
            color = whatColor;
            textColor = whatTextColor;
            phrase = whatPhrase;
            size = whatSize;
            isFull = false;
            
        }
        public void Fill()
        {
            if (isFull == false)
            {
                isFull = true;
                Console.WriteLine("you poured coffee into " + this.phrase);
            } 
            else
            {
                Console.WriteLine("Coffee spills ALL OVER THE PLACE! It was already full, What were you thinking");
            }
        }
        public void Drink()
        {
            if (isFull == true)
            {
                isFull = false;
                Console.WriteLine("you drink some coffee out of" + this.phrase + ".It tastes great!");
            }
            else
            {
                Console.WriteLine("There's no coffee in there! Fill it up First!");
            }
        }
    }
}
