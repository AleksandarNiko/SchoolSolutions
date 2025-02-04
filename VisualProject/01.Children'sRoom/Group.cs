using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Children_sRoom
{
    public class Group
    {

        public GroupType Name { get; set; }

        public string Day { get; set; }
        public string Hour { get; set; }

        public Group(GroupType name, string day, string hour)
        {
            Name = name;
            Day = day;
            Hour = hour;
        }
    }
}

public enum GroupType
{
    МХ,
    ИВД,
    МП,
    АПИ,
    Р,
    ММЖ
}
