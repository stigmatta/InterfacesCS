using ArrayClass;

MyArray arr = new MyArray(10);

arr.Print();

Console.WriteLine(arr.Less(15));
Console.WriteLine(arr.Greater(15));

arr.ShowEven();
arr.ShowOdd();

Console.WriteLine(arr.CountDistinct());