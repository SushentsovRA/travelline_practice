Console.WriteLine( "Введите наименование товара: " );
string productName = Console.ReadLine();

Console.WriteLine( "Введите количество товара: " );
string countStr = Console.ReadLine();

int count = int.Parse( countStr );
Console.WriteLine( "Введите свое имя: " );

string customerName = Console.ReadLine();
Console.WriteLine( "Введите адрес для доставки: " );

string address = Console.ReadLine();
DateTime todayDate = DateTime.Now;
DateTime deliveryDate = todayDate.AddDays( 3 );

Console.WriteLine( $"Ваш заказ {productName} в количестве {count} штук оформлен!\nОжидайте доставку по адресу {address} к {deliveryDate.ToLongDateString()}" );
