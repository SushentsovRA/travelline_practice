var Words = new Dictionary<string, string>();
string[] lines = File.ReadAllLines( "C:\\Users\\SuperD\\Desktop\\Hello.txt" );
bool Exists = true;
foreach ( string word in lines )
{

    if ( Exists = Words.ContainsValue( word ) )
    {
        continue;
    }
    else
    {
        int a = Words.Count;
        string aStr = a.ToString();
        Words.Add( aStr, word );
    }

}
foreach ( var writeWord in Words )
{
    Console.WriteLine( $"key: {writeWord.Key}  value: {writeWord.Value}" );
}