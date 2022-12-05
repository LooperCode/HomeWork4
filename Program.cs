Console.WriteLine("Введите размер");
int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i<n ; i++)
            {
                Console.WriteLine($"Введите {i}-й элемент");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            int k = 0;
            for (int i = 0; i < a.Length; i++) {
                 if (a[k] == a[a.Length - 1]){
                Console.Write(a[k]);
            }
            else {
            Console.Write(a[k] + ", "); k++;
            }
            }