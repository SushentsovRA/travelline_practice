double balance = 10000;
Console.WriteLine( "Введите PIN-код" );
string pincodeStr = Console.ReadLine();
int pincode = int.Parse( pincodeStr );
if ( pincode == 1111 )
{
    Console.WriteLine( $"Ваш текущий баланс {balance} у.е.\nНажмите 1, чтобы снять деньги\nНажмите 2, чтобы пополнить баланс\nНажмите другое число, чтобы выйти" );
    string chooseStr = Console.ReadLine();
    int choice = int.Parse( chooseStr );
    while ( choice == 1 | choice == 2 )
    {
        if ( choice == 1 )
        {
            Console.WriteLine( $"Введите сумму к снятию" );
            string betStr = Console.ReadLine();
            int bet = int.Parse( betStr );
            if ( bet <= balance )
            {
                balance -= bet;
                Console.WriteLine( $"Ваш текущий баланс {balance} у.е.\nНажмите 1, чтобы снять деньги\nНажмите 2, чтобы пополнить баланс\nНажмите другое число, чтобы выйти" );
                choice = int.Parse( Console.ReadLine() );
            }
            else
            {
                Console.WriteLine( "У Вас недостаточно средств для снятия" );
            }
        }
        else
        {
            Console.WriteLine( $"Введите сумму к пополнению" );
            string betStr = Console.ReadLine();
            int bet = int.Parse( betStr );
            balance += bet;
            Console.WriteLine( $"Ваш текущий баланс {balance} у.е.\nНажмите 1, чтобы снять деньги\nНажмите 2, чтобы пополнить баланс\nНажмите другое число, чтобы выйти" );
            choice = int.Parse( Console.ReadLine() );
        }
    }
    Console.WriteLine( "Выход..." );
}
else
    Console.WriteLine( "Введен неверный пароль" );
