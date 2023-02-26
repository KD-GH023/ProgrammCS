// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и конечную строку

string st="hello my friend!";
string w = Console.ReadLine();
string v ="ooo";
string st2=st.Replace(w,v);

Console.WriteLine(st);
Console.WriteLine (st.Replace(w,v));
