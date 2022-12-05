
Console.WriteLine("Введите число");
int insert = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (insert > 0) {
    sum = sum + insert % 10;
    insert = insert / 10;
}
Console.WriteLine(sum);