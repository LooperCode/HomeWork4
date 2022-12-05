Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B");
int b = Convert.ToInt32(Console.ReadLine());
int temp = a;
for (int i = 1; i < b ; i++){
    a = a*temp;
}
Console.WriteLine($"Натуральная степерь числа {temp}: {a} ");