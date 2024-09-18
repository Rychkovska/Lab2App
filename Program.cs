using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2lib;
 
namespace Lab2App
{
	internal class Program
	{
		static void Main(string[] args) 
		{
			Book[] arrBook;
			Console.WriteLine("Введiть кiлькiсть книг: ");
			int cntBook= int.Parse(Console.ReadLine());
			arrBook = new Book[cntBook];
			Console.WriteLine();
			for(int i = 0; i < cntBook; i++) 
			{
				Console.Write("\nВведiть назву книги: ");
				string sTitle = Console.ReadLine();

				Console.Write("Введiть автора книги: ");
				string sAuthor = Console.ReadLine();

				Console.Write("Введiть кiлькiсть сторiнок: ");
				string sNumPages = Console.ReadLine();

				Console.Write("Введiть загальну кiлькiсть слiв у книзi: ");
				string sWordCount = Console.ReadLine();

				Console.Write("Введiть видавця книги: ");
				string sPublisher = Console.ReadLine();

				Console.Write("Введiть рiк видання: ");
				string sYearPublished = Console.ReadLine();

				Console.Write("Введiть мову книги: ");
				string sLanguage = Console.ReadLine();

				Console.Write("ВВедiть жанр книги: ");
				string sGenre = Console.ReadLine();

				Console.Write("-----------------------------");

				Book OurBook = new Book();
				OurBook.Title = sTitle;
				OurBook.Author = sAuthor;
				OurBook.NumPages = int.Parse(sNumPages);
				OurBook.WordCount = int.Parse(sWordCount);
				OurBook.Publisher = sPublisher;
				OurBook.YearPublished = int.Parse(sYearPublished);
				OurBook.Language = sLanguage;
				OurBook.Genre = sGenre;
				double wordsPerPage = OurBook.CalculateWordsPerPage();
				bool sizeofbook = OurBook.IsLargeBook();
				arrBook[i]= OurBook;
				
			}
			foreach(Book t in arrBook)
			{
				Console.WriteLine("\nIнформацiя про книгу:");
				Console.WriteLine("-------------------------");
				Console.WriteLine("Назва книги: " + t.Title);
				Console.WriteLine("Автор: " + t.Author);
				Console.WriteLine("Кiлькiсть сторiнок: " + t.NumPages);
				Console.WriteLine("Кiлькiсть слiв: " + t.WordCount);
				Console.WriteLine("Видавець: " + t.Publisher);
				Console.WriteLine("Рiк видання: " + t.YearPublished);
				Console.WriteLine("Мова: " + t.Language);
				Console.WriteLine("Жанр: "+ t.Genre);
				Console.WriteLine("Кiлькiсть слiв на сторiнцi: " + t.CalculateWordsPerPage());
				if (t.IsLargeBook())
				{
					Console.WriteLine("Це велика книга.");
				}
				else
				{
					Console.WriteLine("Це не велика книга.");
				}
			
			}
			Console.WriteLine();
			Console.Write("Натиснiть будь-яку клавішу, щоб закрити...");
			Console.ReadKey();
		}
	}
}