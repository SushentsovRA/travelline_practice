using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Engines;

namespace CarFactory.WheelPositions;
internal class CreationWheelPosition
{
    public static IWheelPosition ChooseWheelPosition( string WheelPosition )
    {
        switch ( WheelPosition )
        {
            case "1":
                return new LeftPosition();
            case "2":
                return new RightPosition();
            default:
                return new LeftPosition();
        }
    }
}
