// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
//1. (x>0 and y>0)
//2. (x<0 and y>0)
//3. (x<0 and y<0)
//4. (x>0 and y<0)
int X,Y;
System.Console.WriteLine ("Введите X:");
X=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите Y:");
Y=Convert.ToInt32(Console.ReadLine());
if (X >0 && Y > 0) Console.WriteLine ("1 четыерть");
else
if (X <0 && Y > 0) Console.WriteLine ("2 четыерть");
else
if (X <0 && Y < 0) Console.WriteLine ("3 четыерть");
else
if (X >0 && Y < 0) Console.WriteLine ("4 четыерть");
else Console.WriteLine ("X и/или Y равны нулю. Значение X и/или Y заданы не в соответствии с условиями");