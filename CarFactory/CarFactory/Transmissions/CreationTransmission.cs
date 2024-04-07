using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Transmissions;

namespace CarFactory.Transmissions;
public class CreationTransmission
{
    public static ITransmission ChooseTransmission( string Transmission )
    {
        switch ( Transmission )
        {
            case "1":
                return new Manual();
            case "2":
                return new Automatic();
            default:
                return new Manual();
        }
    }
}
