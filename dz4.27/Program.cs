Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum =0;

while(number > 0)
{ 
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");