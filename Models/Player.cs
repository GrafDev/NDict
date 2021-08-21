using System;
using System.Collections.Generic;
using System.Text;

namespace NDict.Models
{
    static class Player
    {
        static User user = new User();

        internal static User User { get => user; set => user = value; }
    }
}
