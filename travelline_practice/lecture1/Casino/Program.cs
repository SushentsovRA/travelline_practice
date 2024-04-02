double balance = 10000;
double multiplicator = 0.1;
Random rnd = new Random();
int GetBet()
{
    string betStr = Console.ReadLine();
    int bet = int.Parse( betStr );
    return bet;
}
while ( balance > 0 )
{

    Console.WriteLine( $"Ваш текущий баланс {balance} у.е. Сделайте Вашу ставку" );
    int bet = GetBet();
    if ( bet <= balance )
    {
        if ( bet >= 0 )
        {
            int randomNumber = rnd.Next( 1, 21 );
            if ( randomNumber == 18 || randomNumber == 19 || randomNumber == 20 )
            {
                balance += bet * ( 1 + ( multiplicator * randomNumber ) % 17 );
            }
            else
            {
                balance -= bet;
            }
        }
        else
            Console.WriteLine( "Ставка отрицательная, не хулиганьте" );
    }
    else
    {
        Console.WriteLine( "Ставка выше баланса, попробуйте снова" );
    }
}
Console.WriteLine( "Баланс исчерпан" );