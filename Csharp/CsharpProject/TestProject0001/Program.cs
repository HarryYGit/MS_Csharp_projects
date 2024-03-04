// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string[] names = {"Rob", "Tom", "Jack"};
// foreach (string name in names)
// {
//     System.Console.WriteLine(name);
// }

int[] inventory = {200, 300, 400, 500};
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
    sum += item;
    bin ++;
    System.Console.WriteLine($"For bin number {bin}, we have totoal {item} remain");
}
System.Console.WriteLine($"we have total {sum} items.");
                          