using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest15._2
{
    static class FindAndReplaceManager
    {
        public static void FindNext(string str, Book book)
        {
            if (book.Content.Contains(str)) { Console.WriteLine("Строка найдена в книге."); }
            else { Console.WriteLine("Строка не найдена в книге."); }
        }
    }

    class Book
    {
        public string Content { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Content = "" +
                "All you women who want a man of the street\r\n" +
                "An' don’t know which way you wanna turn\r\n" +
                "Just keep a-coming\r\n" +
                "and put your hand out to me\r\n" +
                "'Cause I’m the one who’s going to make you burn\r\n" +
                "I’m going to take you down\r\nOh, down, down, down\r\n" +
                "So, don’t you fool around\r\n" +
                "I’m gonna pull it, pull it\r\n" +
                "Pull the trigger\r\n" +
                "Shoot to thrill, play to kill\r\n" +
                "Too many women with too many pills, yeah\r\n" +
                "Shoot to thrill, play to kill\r\n" +
                "I got my gun at the ready, gonna fire at will, yeah\r\n" +
                "I’m like evil, I get under your skin\r\n" +
                "Just like a bomb that’s ready to blow\r\n" +
                "'Cause I’m illegal\r\n" +
                "I got everything that all you women might need to know\r\n" +
                "I’m gonna take you down\r\n" +
                "Yeah, down, down, down\r\n" +
                "So, don’t you fool around\r\n" +
                "I’m gonna pull it, pull it\r\n" +
                "Pull the trigger";

            Console.WriteLine("Введите строку для поиска:");
            string searchStr = Console.ReadLine();

            FindAndReplaceManager.FindNext(searchStr, book);

            Console.ReadKey();
        }
    }
}
