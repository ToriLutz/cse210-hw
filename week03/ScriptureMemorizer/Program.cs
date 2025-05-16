using System;

namespace ScriptureMemorizer
{
    
    public class Word
    {
        public string Text { get; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }
    }

 
    public class Reference
    {
        public string Book { get; }
        public int Chapter { get; }
        public int Verse { get; }

        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }

    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private static Random _random = new Random();

        public Scripture(string text, string book, int chapter, int verse)
        {
            _reference = new Reference(book, chapter, verse);
            _words = new List<Word>();

            string[] splitText = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in splitText)
            {
                _words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine(_reference);
            foreach (Word word in _words)
            {
                if (word.IsHidden)
                {
                    Console.Write(new string('_', word.Text.Length) + " ");
                }
                else
                {
                    Console.Write(word.Text + " ");
                }
            }
            Console.WriteLine();
        }

        public bool HideRandomWords(int count)
        {
            
            List<Word> visibleWords = GetVisibleWords();

            if (visibleWords.Count == 0)
                return false; 

            int hideCount = Math.Min(count, visibleWords.Count);
            for (int i = 0; i < hideCount; i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index); 
            }
            return true;
        }

        private List<Word> GetVisibleWords()
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden)
                {
                    visibleWords.Add(word);
                }
            }
            return visibleWords;
        }

        public bool AllHidden()
        {
            foreach (var word in _words)
            {
                if (!word.IsHidden)
                    return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Trust in the LORD, with all thine heart; and lean not unto thine own understanding.";
            Scripture scripture = new Scripture(text, "Proverbs", 3, 5);

            while (!scripture.AllHidden())
            {
                Console.Clear();
                scripture.Display();
                scripture.HideRandomWords(1);

                Console.WriteLine("\nPress Enter to hide more words...");
                Console.ReadLine();
            }

            Console.Clear();
        }
    }
}
