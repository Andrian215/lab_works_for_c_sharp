using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface ISides
    {
        int Sides { get; set; }
        void AssignmentSides();
    }

    public interface ICoordinates
    {
        int Coordinates { get; set; }
        void AssignmentCoordinates();
    }
}
