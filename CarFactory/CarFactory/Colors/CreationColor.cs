using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Brands;

namespace CarFactory.Colors;
public class CreationColor
{
    public static IColor ChooseColor( string Color )
    {
        switch ( Color )
        {
            case "1":
                return new White();
            case "2":
                return new Black();
            case "3":
                return new Grey();
            default:
                return new White();
        }
    }
}
