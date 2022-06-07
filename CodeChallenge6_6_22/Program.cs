
//Problem 1 Input Gathering
Console.WriteLine("Enter the number of triples");
int N = Int32.Parse(Console.ReadLine());
int[][] triples=new int[N][];
for(int i=0; i<N; i++)
{
Console.WriteLine("Enter three distinct numbers space separated:");
string? triple=Console.ReadLine();
string[] tokens=triple.Split(' ');
triples[i]=Array.ConvertAll(tokens, int.Parse);
}

//Problem 1 Solution
GetSecondMaxNum(triples);


//Problem 2 Input gathering
Console.WriteLine("Input the number of test cases");
int tests=Int32.Parse(Console.ReadLine());
string [] inputs = new string [tests];
for(int i=0; i<tests; i++)
{
    Console.WriteLine("Enter a string with letters and digits to test");
    inputs[i]=Console.ReadLine();
}

//Problem 2 solution
FindSumOfDigits(inputs);



static void GetSecondMaxNum(int [][] triples)
{
    Console.WriteLine("Problem 1 Output");
    for (int i=0; i<triples.Length; i++)
    {
        Array.Sort(triples[i]);
        Console.WriteLine(triples[i][1]);
    }

}

static void FindSumOfDigits(string [] input)
{
    Console.WriteLine("Output Problem 2");
    for(int i=0; i<input.Length; i++)
    {
        int sum=0;
        foreach(char c in input[i])
        {
            if(Char.IsDigit(c))
            {
                sum+=(int)c-48;
            }
        }
        Console.WriteLine(sum);
    }

}
