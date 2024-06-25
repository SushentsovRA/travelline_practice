using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Fighters;
using Fighters.Models.Races;
using Fighters.Models.Weapons;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Fighters;

public class Program
{
    public static void Main()
    {
        var firstFighter = new Fighter( GetFighterName(), GetFighterRace(), GetFighterClass(), GetFighterWeapon(), GetFighterArmor() );
        var secondFighter = new Fighter( GetFighterName(), GetFighterRace(), GetFighterClass(), GetFighterWeapon(), GetFighterArmor() );

        var master = new GameMaster();
        var winner = master.PlayAndGetWinner( firstFighter, secondFighter );

        Console.WriteLine( $"Выигрывает  {winner.Name}" );
    }

    public static string GetFighterName()
    {
        Console.WriteLine( "Введите имя бойца: " );

        string FighterName = Console.ReadLine();
        return FighterName;
    }

    public static IRace GetFighterRace()
    {
        Console.WriteLine( "Выберите расу:" +
           $"{Environment.NewLine}1 - Человек" +
           $"{Environment.NewLine}2 - Каджит" +
           $"{Environment.NewLine}3 - Орк" );

        string race = Console.ReadLine();
        return ChooseRace( race );
    }

    private static IRace ChooseRace( string Race )
    {
        switch ( Race )
        {
            case "1":
                return new Human();
            case "2":
                return new Khajiit();
            case "3":
                return new Orc();
            default:
                return new Human();
        }
    }
    public static IClass GetFighterClass()
    {
        Console.WriteLine( "Выберите класс: " +
            $"{Environment.NewLine}1 - Воин" +
            $"{Environment.NewLine}2 - Маг" +
            $"{Environment.NewLine}3 - Бандит" );

        string fighterclass = Console.ReadLine();
        return ChooseClass( fighterclass );
    }
    private static IClass ChooseClass( string Class )
    {
        switch ( Class )
        {
            case "1":
                return new Warrior();
            case "2":
                return new Wizard();
            case "3":
                return new Bandit();
            default:
                return new Warrior();
        }
    }

    public static IWeapon GetFighterWeapon()
    {
        Console.WriteLine( "Выберите оружие: " +
            $"{Environment.NewLine}1 - Меч" +
            $"{Environment.NewLine}2 - Топор" +
            $"{Environment.NewLine}3 - Нет оружия" );

        string weapon = Console.ReadLine();
        return ChooseWeapon( weapon );
    }

    private static IWeapon ChooseWeapon( string Weapon )
    {
        switch ( Weapon )
        {
            case "1":
                return new Sword();
            case "2":
                return new Axe();
            case "3":
                return new NoWeapon();
            default:
                return new NoWeapon();
        }
    }
    public static IArmor GetFighterArmor()
    {
        Console.WriteLine( "Выберите броню: " +
            $"{Environment.NewLine}1 - Легкая броня" +
            $"{Environment.NewLine}2 - Тяжелая броня" +
            $"{Environment.NewLine}3 - Нет брони" );

        string armor = Console.ReadLine();
        return ChooseArmor( armor );
    }
    private static IArmor ChooseArmor( string Armor )
    {
        switch ( Armor )
        {
            case "1":
                return new LightArmor();
            case "2":
                return new HeavyArmor();
            case "3":
                return new NoArmor();
            default:
                return new NoArmor();
        }
    }

    public class GameMaster
    {
        public IFighter PlayAndGetWinner( IFighter firstFighter, IFighter secondFighter )
        {
            int round = 1;
            while ( true )
            {
                Console.WriteLine( $"Раунд {round++}." );

                // First fights second
                if ( FightAndCheckIfOpponentDead( firstFighter, secondFighter ) )
                {
                    return firstFighter;
                }

                // Second fights first
                if ( FightAndCheckIfOpponentDead( secondFighter, firstFighter ) )
                {
                    return secondFighter;
                }

                Console.WriteLine();
            }

            throw new UnreachableException();
        }

        private bool FightAndCheckIfOpponentDead( IFighter roundOwner, IFighter opponent )
        {
            int damage = roundOwner.CalculateDamage() - opponent.CalculateDefense();
            opponent.TakeDamage( damage );

            Console.WriteLine(
                $"Боец {opponent.Name} получает {damage} урона. " +
                $"Количество жизней: {opponent.CurrentHealth}" );

            return opponent.CurrentHealth < 1;
        }
    }
}