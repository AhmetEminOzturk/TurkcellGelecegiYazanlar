//diziye ait elemanların toplamlarını - ortalamalarını - en buyuk sayısını ve en kucuk sayısını veren programı dongu kullanarak yazınız


Console.WriteLine("Enter 5 numbers");
int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("******************************************");
//dizi elemanlarının toplamı
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Sum of numbers: {sum}");

//dizi elemanlarının aritmetik ortalaması
Console.WriteLine("Average of numbers: " + (sum / numbers.Length));

//dizi elemanlarının en buyugu
int maxNumber = int.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= maxNumber)
    {
        maxNumber = numbers[i];
    }
}
Console.WriteLine($"Max number: {maxNumber}");

//dizi elemanlarının en kucugu
int minNumber = int.MaxValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] <= minNumber)
    {
        minNumber = numbers[i];
    }
}
Console.WriteLine($"Min number: {minNumber}");
