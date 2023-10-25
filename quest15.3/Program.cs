using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quest15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
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
                
                int count = 0;
                while (count <= 9) 
                { 
                    Console.WriteLine("Введите заметку:");
                    string note = Console.ReadLine();

                    book.AddNote(note);
                    count++;
                }
                Console.WriteLine("Заметки читателя:");
                foreach (string n in book.GetNotes()) { Console.WriteLine(n); }

                Console.ReadLine();
            }
        }
    }

    class Book
    {
        public string Content { get; set; }
        private Notes notes;

        public Book() { notes = new Notes(); }

        public void AddNote(string note) { notes.Add(note); }

        public string[] GetNotes() { return notes.GetNotes(); }

        public class Notes
        {
            private string[] notes;
            private int count;

            public Notes()
            {
                notes = new string[10];
                count = 0;
            }

            public void Add(string note)
            {
                if (count < notes.Length) 
                { 
                    notes[count] = note; count++; 
                }
                else {  Console.WriteLine("Достигнуто максимальное количество заметок."); }
            }
            public string[] GetNotes() { return notes; }
        }
    }
}
