using CarFactory.Bodies;
using CarFactory.Brands;
using CarFactory.Colors;
using CarFactory.Engines;
using CarFactory.Transmissions;
using CarFactory.WheelPositions;
using CarFactory.Car;
using System.Drawing;
using System.Security.Cryptography;

namespace CarFactory;
public class Program
{
    public static void Main()
    {
        var newCar = new Car.Car( GetBody(), GetBrand(), GetColor(), GetEngine(), GetTransmission(), GetWheelPosition() );
        Console.WriteLine( $"Для Вас будет изготовлен автомобиль:" +
            $"{Environment.NewLine}Марка  - {newCar.Brand.Name}" +
            $"{Environment.NewLine}Кузов - {newCar.Body.Name}" +
            $"{Environment.NewLine}Цвет - {newCar.Color.Name}" +
            $"{Environment.NewLine}Двигатель - {newCar.Engine.Name}" +
            $"{Environment.NewLine}Коробка передач - {newCar.Transmission.Name}" +
            $"{Environment.NewLine}Расположения руля - {newCar.WheelPosition.Name}" +
            $"{Environment.NewLine}Максимальная скорость - {newCar.MaxSpeed}" +
            $"{Environment.NewLine}Количество передач - {newCar.Transmission.NumberOfGears}" );
    }
    public static IBrand GetBrand()
    {
        Console.WriteLine( "Выберите марку (введите цифру):" +
           $"{Environment.NewLine}1 - Skoda" +
           $"{Environment.NewLine}2 - Volkswagen" );
        string brand = Console.ReadLine();
        return CreationBrand.ChooseBrand( brand );
    }
    public static IBody GetBody()
    {
        Console.WriteLine( "Выберите кузов (введите цифру):" +
           $"{Environment.NewLine}1 - Седан" +
           $"{Environment.NewLine}2 - Купе" +
           $"{Environment.NewLine}3 - Хэтчбек" );
        string body = Console.ReadLine();
        return CreationBody.ChooseBody( body );
    }
 
    public static IColor GetColor()
    {
        Console.WriteLine( "Выберите цвет (введите цифру):" +
           $"{Environment.NewLine}1 - Белый" +
           $"{Environment.NewLine}2 - Черный" +
           $"{Environment.NewLine}3 - Серый" );
        string color = Console.ReadLine();
        return CreationColor.ChooseColor( color );
    }
    public static IEngine GetEngine()
    {
        Console.WriteLine( "Выберите тип двигателя (введите цифру):" +
           $"{Environment.NewLine}1 - Бензиновый" +
           $"{Environment.NewLine}2 - Дизельный" );
        string engine = Console.ReadLine();
        return CreationEngine.ChooseEngine( engine );
    }
    public static ITransmission GetTransmission()
    {
        Console.WriteLine( "Выберите коробку передач (введите цифру):" +
           $"{Environment.NewLine}1 - Автоматическая" +
           $"{Environment.NewLine}2 - Ручная" );
        string transmission = Console.ReadLine();
        return CreationTransmission.ChooseTransmission( transmission );
    }
    public static IWheelPosition GetWheelPosition()
    {
        Console.WriteLine( "Выберите расположение руля (введите цифру):" +
           $"{Environment.NewLine}1 - Слева" +
           $"{Environment.NewLine}2 - Справа" );
        string wheelPosition = Console.ReadLine();
        return CreationWheelPosition.ChooseWheelPosition( wheelPosition );
    }
}