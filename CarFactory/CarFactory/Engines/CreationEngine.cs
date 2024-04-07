using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Brands;

namespace CarFactory.Engines;
public class CreationEngine
{
    public static IEngine ChooseEngine( string Engine )
    {
        switch ( Engine )
        {
            case "1":
                return new Gasoline();
            case "2":
                return new Diesel();
            default:
                return new Gasoline();
        }
    }
}
