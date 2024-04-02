double balance = 10000;
Console.WriteLine( "Введите PIN-код" );
string pincodeStr = Console.ReadLine();
int pincode = int.Parse( pincodeStr );
int GetUserAction()
{
    Console.WriteLine( $"Ваш текущий баланс {balance} у.е." +
    $"{Environment.NewLine}Нажмите 1, чтобы снять деньги" +
    $"{Environment.NewLine}Нажмите 2, чтобы пополнить баланс" +
    $"{Environment.NewLine}Нажмите другое число, чтобы выйти" );
    string chooseStr = Console.ReadLine();
    int choice = int.Parse( chooseStr );
    return choice;
}
int HandleWithdrawal()
{
    Console.WriteLine( $"Введите сумму к снятию" );
    string betStr = Console.ReadLine();
    int bet = int.Parse( betStr );
    return bet;
}
int HandleReplenishment()
{
    Console.WriteLine( $"Введите сумму к пополнению" );
    string betStr = Console.ReadLine();
    int bet = int.Parse( betStr );
    return bet;
}
if ( pincode == 1111 )
{
    int choice = GetUserAction();

    while ( choice == 1 || choice == 2 )
    {
        if ( choice == 1 )
        {
            int bet = HandleWithdrawal();
            if ( bet <= balance )
            {
                balance -= bet;
                choice = GetUserAction();
            }
            else
            {
                Console.WriteLine( "У Вас недостаточно средств для снятия" );
            }
        }
        else
        {
            int bet = HandleReplenishment();
            balance += bet;
            choice = GetUserAction();
        }
    }
    Console.WriteLine( "Выход..." );
}
else
    Console.WriteLine( "Введен неверный пароль" );
