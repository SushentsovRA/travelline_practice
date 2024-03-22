Console.WriteLine( "Введите количество долларов: " );
var dol1 = Console.ReadLine();
decimal dol = Convert.ToDecimal( dol1 );
decimal course = 91.33333M;
decimal rezult = dol * course;
Console.WriteLine( $"{dol} долларов - это {rezult} рублей" );
