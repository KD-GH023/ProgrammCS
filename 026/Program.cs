// 26.Программа проверяет пятизначное число на палиндромом.
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length < 5 || anyNumberText[0]==anyNumberText[4] && anyNumberText[1]==anyNumberText[3]) Console.WriteLine ("Число -палиндром");
  else Console.WriteLine ("Число не является пятизначным палиндромом");
