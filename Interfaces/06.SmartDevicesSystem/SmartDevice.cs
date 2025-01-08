using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06.SmartDevicesSystem.Interfaces;

namespace _06.SmartDevicesSystem
{
    public class SmartDevice : IConnectable, IControllable
    {
        private bool isActive = false;
        private bool isConnected = false;

        public  string Name { get; set; }

        public void ShowStatus()
        {
            if (isActive == true && isConnected == false)
            {
                Console.WriteLine("Устройството е включено, но не е свързано към мрежата.");
            }
            else if (isActive == false && isConnected == true) 
            {
                Console.WriteLine("Устройството не е включено, но е свързано към мрежата.");
            }
            else if(isActive==true && isConnected == true)
            {
                Console.WriteLine("Устройството е включено и е свързано към мрежата.");
            }
            else
            {
                Console.WriteLine("Устройството не е включено и не е свързано към мрежата.");
            }
        }

        public void Connect(string network)
        {
            Console.WriteLine($"Смарт устройството е свързано към мрежата: {network}.");
            isConnected = true;
        }

        public void Disconnect()
        {
            Console.WriteLine("Смарт устройството е изключено от мрежата.");
            isConnected = false;
        }

        public void TurnOff()
        {
            Console.WriteLine("Смарт устройството е изключено.");
            isActive = false;
        }

        public void TurnOn()
        {
            Console.WriteLine("Смарт устройството е включено.");
            isActive = true;
        }
    }
}
