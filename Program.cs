Console.WriteLine("Введите число");
int insert = Convert.ToInt32(Console.ReadLine());
int temp = insert;
if (insert < 1000) {
    temp = insert % 100;
    temp = (insert / 100 )+ (temp /10)+ (insert%10);
}
else if (insert < 10000) {
    temp = insert % 1000/10; 
    temp = (insert / 1000) + (temp / 10) + (temp % 10) + (insert % 10);
}
else if (insert < 100000){
    temp = insert / 100 % 100;
    temp = (insert / 10000) + (temp / 10 ) + (temp % 10) + (insert % 100 / 10) + (insert % 10)  ;
}
else if (insert < 1000000){
    temp = insert / 1000;
    temp = (temp / 100) + (temp % 100) / 10 + (temp % 10);
    temp = temp + (insert % 1000)/100 + (insert % 1000) % 100 / 10 + (insert % 10);
}
Console.WriteLine(temp);
