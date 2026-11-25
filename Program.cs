// Task 1

// using System.Runtime.InteropServices;

// Person person1 = new Person("Max","Karabolo");
// System.Console.WriteLine();
// Student person2= new Student("Alex","Profsouz","sum",2026,500.1);
// System.Console.WriteLine();
// Staff person3 = new Staff("Ball","avtovagzal","school№1",1000);
// person1.GEtName("Max");
// person1.GEtAddress("karabolo");
// System.Console.WriteLine();
// person2.GEtName("Max");
// person2.GEtAddress("karabolo");
// System.Console.WriteLine();
// person3.GEtName("Max");
// person3.GEtAddress("karabolo");


// task 3
List<int> list = new List<int>()
{
    3, 0, 7, -2, 7, 15, -60, 32,
    0, -2, 90, 32, 55, 8, -9
};
int min=99999;
foreach (var item in list)
{
    if (min > item)
    {
        min=item;
    }
}
System.Console.Write($"MIn: {min}.");
System.Console.WriteLine();
list.Distinct();
foreach (var item in list)
{
    System.Console.Write($"{item} ");
}
System.Console.WriteLine();
list.Sort();
list.Reverse();
foreach (var item in list)
{
    System.Console.Write($"{item} ");
}
System.Console.WriteLine();
foreach (var item in list)
{
    if(item<0)
    {
        System.Console.Write(0);
        continue;
    }
    System.Console.Write($"{item} ");
}