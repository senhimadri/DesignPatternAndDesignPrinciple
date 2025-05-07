// See https://aka.ms/new-console-template for more information

using System.Collections;

ArrayList list = new ArrayList();

list.Add(1);
list.Add("Himadri");

for(int i =0; i < 2; i++)
{
    Console.WriteLine(list[i]);
}

Console.ReadLine();

Console.WriteLine("Hello, World!");


var tuple = Tuple.Create(1,"Alies");

var valueTuple = (Id: 1, Name: "Name", Age: 10);

Console.WriteLine($"Id is {valueTuple.Id} Name is: {valueTuple.Name}");


