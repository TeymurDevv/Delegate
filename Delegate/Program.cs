using Delegate.Helpers;
using System.Text;

//void Info(string m, string n)
//{
//   Console.WriteLine($"Info: {m} {n}");
//}

//Print print = Info;
//print("lorem", "ipsum");

Console.WriteLine(Sum(n=>n%2==0,2,3,4,5));
//Console.WriteLine(Sum(n => n % 2 == 1, 2, 3, 4, 5));
//Console.WriteLine(Sum(n => n >= 5, 2, 3, 4, 5));

int Sum(Func<int,bool> method, params int[] arr)
{
    int sum = 0;
    foreach (var item in arr)
    {
        if (method(item))
        {
            sum += item;
        }
    }
    return sum;
}

void Info(string m)
{
    Console.WriteLine(m);
}
void printLength(string word)
{
   Console.WriteLine(word.Length);
}
void PrintToLower(string word)
{
    Console.WriteLine(word.ToLower());
}
void PrintToUpper(string word)
{
    Console.WriteLine(word.ToUpper());
}

Print print = Info;
print += printLength;
print += PrintToUpper;
print -= PrintToUpper;
////anonim
print += delegate (string word)
{
    Console.WriteLine(word[0]);
};
print += delegate (string word1)
{
    Console.WriteLine(word1[1]);
};
//lambda expression
print += m =>
{
    Console.WriteLine(m[2]);
};
print += PrintToLower;
print("lorem");
//Calculate calculate = (m, l) => m + l;

//calculate += (l, a) => l - a;

//Console.WriteLine(calculate(2,3));

//Print<int> print = m =>
//{
//    Console.WriteLine(m);
//};
//Print<string> print2 = m =>
//{

//    Console.WriteLine(m);
//};
//Print<int, string, int> print = (c, d) => "";
//print(1, "lorem");

//action,predicate,func
//Action<int, int, int> action = (m, n, l) =>
//{

//    Console.WriteLine(m + n + l);
//};
//action(1, 2, 3);
//Action<int, string> action2 = (m, n) =>
//{

//};
//action2 += (o, p) =>
//{
//    Console.WriteLine(o+p);
//};

Predicate<string> predicate = a => a.Length > 3;

Predicate<int> predicate1 = a => true;
Func<int, int> func = a => 1;

Func<string, string, int> predicate2 = (a, b) => a.Length + b.Length;
Func<char> predicate3 = () => 'A';

Func<int, bool> predicate4 = (a) => a>2;
