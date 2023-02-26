// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа



 string text = Console.ReadLine();
 int temp = 0;
            if (!Int32.TryParse(text, out temp))
                Console.WriteLine("Это не является верной записью целого");
            else {
                int sum = 0;
                foreach (char digit in text)
                    sum += digit - 48;
                Console.WriteLine(sum);}



