using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pot
{
    public interface IHouseholdCourt
    {
        bool IsFull();

        void Add(double quantity);

        void Taking(double quantity);
    }
}