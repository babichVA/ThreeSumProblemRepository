using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ThreeSumProblem
{
    public partial class SetThree
    {
        public List<int> _array { get; }
        public SetThree(List<int> array)
        {
            _array = array;            
        }
        public SetThree()
        {
            _array = new List<int>();
        }
    }
}
