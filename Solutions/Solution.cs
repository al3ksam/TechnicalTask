using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public sealed class Solution
    {
        private Component _mainComponent = new Component();

        private List<Component> _components = new List<Component>();

        public Solution(string name, int volume, Component mainComponent)
        {
            Name = name;
            Volume = volume;

        }

        public string Name { get; private set; }
        public int Volume { get; private set; }
        
        

        public struct Component
        {
            public string Name { get; set; }
            public int Percent { get; set; }
        }
    }
}
