using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Bodies;

namespace CarFactory.Brands;
public class CreationBrand
{
    public static IBrand ChooseBrand( string Brand )
    {
        switch ( Brand )
        {
            case "1":
                return new Skoda();
            case "2":
                return new VW();
            default:
                return new Skoda();
        }
    }
}
