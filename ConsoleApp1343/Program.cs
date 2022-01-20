static class Program
{
    public static string[] currstr = new string[] { "Nickles", "Pennies", "Dimes", "Quarters" };
    static Dictionary<int, int> dictNum = new Dictionary<int, int>()
    {
       {0 , 0},
       {1 , 0},
       {2 , 0},
       {3 , 0},
    };
    public static int[] currency = new int[] { 1, 5, 10, 25 };
    static void Main(string[] args)
    {
        Console.WriteLine($"Найти сумму: {FindSum(12)}");//4
        var dic = CalcNatur(55);//5
        foreach (var item in dic)
            Console.WriteLine(item);
        Console.WriteLine($"Отсортировать число: {SortNum(987654321)}");//6
        Console.WriteLine($"Пирамида: {FindPyramidSum(1)}");//7
        Console.WriteLine($"Вернуть 5: {ReturnFive()}");//8
    }
    // 4 задание
    static int FindSum(int num)
    {
        if (num < 10)
            return num;
        else
        {
            int sum = ConvertNumToArr(num).Sum();
            int res = FindSum(sum);
            return res;
        }
    }
    // 5 задание
    static int CalcCurrency(int cents, int val, out int rem)
    {
        rem = cents % val;
        return cents / val;
    }
    static Dictionary<string, int> CalcNatur(float cents)
    {
        if (cents > 0)
        {
            int intCents = (int)Math.Floor(cents);
            int i = 3;
            while (true)
            {
                dictNum[i] = CalcCurrency(intCents, currency[i], out int rem);
                intCents = rem;
                i--;
                if (rem == 0)
                    break;
            }
        }
        var dictionary = currstr.Select((k, i) => (k, i)).ToDictionary(x => x.k, x => dictNum[x.i]);
        return dictionary;
    }
    // 6 задание
    static int SortNum(int num)
    {
        if (num <= 0)
            return num;
        else
        {
            int[] numbers = ConvertNumToArr(num);
            Array.Sort(numbers);
            int result = int.Parse(String.Join("", numbers));
            return result;
        }
    }
    // 7 задание
    static double FindPyramidSum(int index) => index < 6 ? Math.Pow(index, 3) : index;
    // 8 задание
    static int ReturnFive() => "abcde".Length;
    static int[] ConvertNumToArr(int numb) => numb.ToString().Select(item => int.Parse(item.ToString())).ToArray();
}
