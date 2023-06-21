
/*

static void Main(string[] args)
{

    for (int dan = 2; dan < 10; dan++)
    {
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{dan} 곱하기 {i} 는 {dan * i}");
        }
        Console.WriteLine("공백을 드립니다.");
    }
}

static void Main(string[] args)
{

    for (int dan = 2; dan < 10; dan++)
    {
        for (int i = 1; i < 10; i++)
        {
            Console.Write($"{dan} x {i} 는 {dan * i,2}\t");
        }
        Console.WriteLine();
    }
}

static void Main(string[] args)
{
    int[] jms = new int[4];
    int tot = 0;

    for (int i = 0; i < jms.Length; i++)
    {
        jms[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < jms.Length; i++)
    {
        tot += jms[i];
    }
    Console.WriteLine(tot);
}
