using System;

struct book
{
	public string title;
	public string author;
}
public class strucExer
{
	public static void Main()
	{
		int nobook = 1000;
		book[] books = new book[nobook];
		int i, j, n = 1, k = 1;
		Console.Write("\n\nInsert the information of two books :\n");
		Console.Write("-----------------------------------------\n");
		for (j = 0; j <= n; j++)
		{
			Console.WriteLine("Information of book {0} :", k);

			Console.Write("Input name of the book : ");
			books[j].title = Console.ReadLine();

			Console.Write("Input the author : ");
			books[j].author = Console.ReadLine();
			k++;
			Console.WriteLine();
		}

		for (i = 0; i <= n; i++)
		{
			Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
			Console.WriteLine();
		}

	}
}