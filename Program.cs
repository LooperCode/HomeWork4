
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new Int32[n];
for(int i = 0; i < n; i++){
    Console.WriteLine($"Введите значение элемента {i}");
    
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите количество ступеней сдвига");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
int temp = array[0];
if (k > 0){
    for (int j = 0; j <= k-1; j++){
        for (int i = 0; i < n-1; i++){
            temp = array[i];
            array[i] = array[(i+1)];
            array[i+1] = temp;
       }
   }
}
else if (k < 0) {
    for (int j = n-1; j >= k; j--){
    for (int i = n-1; i > 0; i--){
        temp = array[i];
        array[i] = array[i-1];
        array[i-1] = temp;
    }
}
}
   for (int i = 0; i < n; i++){
    if(i == n-1){
    Console.Write($"[{array[i]}]");
    }
    else{
    Console.Write($"[{array[i]}], ");
   }
   }
   