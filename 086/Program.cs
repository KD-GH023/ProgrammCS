// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке
string text = Console.ReadLine();
char letter = 'a';
int g = text.Count(ch => ch == letter);
Console.WriteLine(g);
