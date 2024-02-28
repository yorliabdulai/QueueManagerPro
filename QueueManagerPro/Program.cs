git push -u origin mainusing System;
using System.Collections.Generic;
 class Program
{
    static void Main()
    {
        Queue<string> namesOfUsers = new Queue<string>();
        namesOfUsers.Enqueue("Tawfiq");
        namesOfUsers.Enqueue("Tiisu");
        namesOfUsers.Enqueue("Abdulai");
        namesOfUsers.Enqueue("Abdul Hafiz");

        //Console.WriteLine($"Number of people in queue is: \n {namesOfUsers.Count}");

        int index = 1;

        foreach (string name in namesOfUsers)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{index}. {name}");
            index++;
        }
        int count = 1;
        while(namesOfUsers.Count > 0)
        {
            Console.WriteLine($"{count}. {namesOfUsers.Dequeue()} Left the queue" );
            count++;
        }
    }
}
