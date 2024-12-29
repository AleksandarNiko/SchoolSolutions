using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Barrel
{
    public class Barrel
    {
        const int volume = 100;

        public Barrel(int currentVolume)
        {
            CurrentVolume = currentVolume;
        }

        public  int CurrentVolume { get; private set; }

        public void AddToBarrel(int liquidToAdd)
        {
            if (CurrentVolume + liquidToAdd > volume)
            {
                Console.WriteLine("Cannot add to the barrel!");
                return;
            }
            else
            {
                CurrentVolume += liquidToAdd;
            }
        }

        public void RemoveFromBarrel(int liquidToRemove)
        {
            if (CurrentVolume < liquidToRemove)
            {
                Console.WriteLine("Cannot remove from the barrel!");
                return;
            }
            else
            {
                CurrentVolume -= liquidToRemove;
            }
        }

        public void CheckAvailability()
        {
            if (CurrentVolume < 0)
            {
                Console.WriteLine("No liquid!");
            }
            else
            {
                Console.WriteLine($"There is {CurrentVolume}L");
            }
        }
    } 
}
