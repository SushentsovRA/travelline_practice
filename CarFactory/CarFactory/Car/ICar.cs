using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Bodies;
using CarFactory.Brands;
using CarFactory.Colors;
using CarFactory.Engines;
using CarFactory.Transmissions;
using CarFactory.WheelPositions;

namespace CarFactory.Car;
public interface ICar
{
    public IBody Body { get; }
    public IBrand Brand { get; }
    public IColor Color { get; }
    public IEngine Engine { get; }
    public ITransmission Transmission { get; }
    public IWheelPosition WheelPosition { get; }
    public int MaxSpeed { get; }
    public int CalculateMaxSpeed();
}