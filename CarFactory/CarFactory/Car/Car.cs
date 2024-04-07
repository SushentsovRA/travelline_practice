using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Bodies;
using CarFactory.Brands;
using CarFactory.Colors;
using CarFactory.Engines;
using CarFactory.Transmissions;
using CarFactory.WheelPositions;

namespace CarFactory.Car;
public class Car : ICar
{
    public IBody Body { get; }
    public IBrand Brand { get; }
    public IColor Color { get; }
    public IEngine Engine { get; }
    public ITransmission Transmission { get; }
    public IWheelPosition WheelPosition { get; }
    public int MaxSpeed { get; }
    public Car( IBody body, IBrand brand, IColor color, IEngine engine, ITransmission transmission, IWheelPosition wheelPosition )
    {
        Body = body;
        Brand = brand;
        Color = color;
        Engine = engine;
        Transmission = transmission;
        WheelPosition = wheelPosition;
        MaxSpeed = CalculateMaxSpeed();
    }

    public int CalculateMaxSpeed()
    {
        return Body.Speed + Engine.Speed + Transmission.Speed;
    }
}