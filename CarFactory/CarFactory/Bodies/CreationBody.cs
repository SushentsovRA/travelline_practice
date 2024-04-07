using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Bodies;
public class CreationBody
{
    public static IBody ChooseBody( string Body )
    {
        switch ( Body )
        {
            case "1":
                return new Sedan();
            case "2":
                return new Coupe();
            case "3":
                return new Hatchback();
            default:
                return new Sedan();
        }
    }
}
