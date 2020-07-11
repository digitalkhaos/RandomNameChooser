using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameChooser
{
    public class NameEntry
    {
        public NameEntry(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
        }
    }
}
