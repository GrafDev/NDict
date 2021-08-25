using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NDict.Models
{
    static class Player
    {
        static User _current = new User();

        internal static User Current { get => _current; set => _current = value; }


    }
}
