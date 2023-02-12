// 45.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] a;
a=new int[5];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");//для наглядности массива
    System.Console.WriteLine();

int counter=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2==0)
       counter++;
       
        System.Console.WriteLine($"Кличество четных чисел:{counter}");
int counter1=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2!=0)
       counter1++;
       
        System.Console.WriteLine($"Кличество нечетных чисел:{counter1}");