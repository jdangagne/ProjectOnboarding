using System.Text.RegularExpressions;

Console.WriteLine("Enter a hex code to check:");
string? hex=Console.ReadLine();
bool isValidHex=IsValidHexCode(hex);
Console.WriteLine($"{hex} is a valid HexCode? : {isValidHex}");

Console.WriteLine("Input a number to get the next prime:");
int inputNum=Int32.Parse(Console.ReadLine());
int nextPrime=NextPrime(inputNum);
Console.WriteLine($"The next prime number is: {nextPrime}");

static bool IsValidHexCode(string hex)
{
    if(hex.Length!=7 || hex[0]!='#')
    {
        return false;
    }

    Regex hexcode = new Regex("[0-9A-Fa-f]{6}");
    if(hexcode.IsMatch(hex))
    {
        return true;
    }
    return false;
}

static int NextPrime(int inputNum)
{
    if(inputNum==0||inputNum==1)
    {return 2;}
    for(int i=2; i<inputNum; i++)
    {
        if(inputNum%i==0)
        {
            inputNum++;
            i=2;
        }
    }
    return inputNum;
}