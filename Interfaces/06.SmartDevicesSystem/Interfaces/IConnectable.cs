using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SmartDevicesSystem.Interfaces
{
    public interface IConnectable
    {
        void Connect(string network);

        void Disconnect();
    }
}
