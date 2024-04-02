Dictionary<string, string> Translation = new Dictionary<string, string>();
string CallMenu()
{
    Console.WriteLine( $"Введите одну из команд:" +
        $"{Environment.NewLine}AddTranslation - добавить перевод" +
        $"{Environment.NewLine}RemoveTranslation - удалить перевод" +
        $"{Environment.NewLine}ChangeTranslation - изменить перевод" +
        $"{Environment.NewLine}Translate - перевести русское слово на английский" +
        $"{Environment.NewLine}Exit - выйти" );
    string command = Console.ReadLine();
    return command;
}
string command = CallMenu();
bool Exists = true;
while ( command != "Exit" )
{
    if ( command == "AddTranslation" )
    {
        Console.WriteLine( "Введите слово на русском" );
        string rus = Console.ReadLine();
        if ( Exists = Translation.ContainsKey( rus ) )
        {
            Console.WriteLine( $"Перевод для этого слова уже есть" );
            command = CallMenu();
        }
        else
        {
            Console.WriteLine( "Введите перевод" );
            string eng = Console.ReadLine();
            Translation.Add( rus, eng );
            command = CallMenu();
        }
    }
    else if ( command == "RemoveTranslation" )
    {
        Console.WriteLine( "Введите слово на русском" );
        string rus = Console.ReadLine();

        if ( Exists = Translation.ContainsKey( rus ) )
        {
            Translation.Remove( rus );
            Console.WriteLine( $"Перевод для слова {rus} удален" );
            command = CallMenu();
        }
        else
        {
            Console.WriteLine( $"Перевод для такого слова уже отсутствует" );
            command = CallMenu();
        }
    }
    else if ( command == "ChangeTranslation" )
    {
        Console.WriteLine( "Введите слово на русском" );
        string rus = Console.ReadLine();

        if ( Exists = Translation.ContainsKey( rus ) )
        {
            Console.WriteLine( "Введите перевод" );
            string eng = Console.ReadLine();
            Translation.Add( rus, eng );
            command = CallMenu();
        }
        else
        {
            Console.WriteLine( $"Перевод для такого слова отсутствует" );
            command = CallMenu();
        }
    }
    else if ( command == "Translate" )
    {
        Console.WriteLine( "Введите слово на русском" );
        string rus = Console.ReadLine();
        if ( Exists = Translation.ContainsKey( rus ) )
        {
            Console.WriteLine( $"{rus} переводится {Translation[ rus ]}" );
            command = CallMenu();
        }
        else
        {
            Console.WriteLine( $"Перевод для такого слова отсутствует" );
            command = CallMenu();
        }
    }
    else
    {
        Console.WriteLine( "Неизвестная команда, попробуйте еще раз" );
        command = CallMenu();
    }
}
Console.WriteLine( "Выход..." );
