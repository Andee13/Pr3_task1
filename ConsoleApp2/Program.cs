using System;
using System.IO;
using System.Text;

namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // лічильник слів, де d стоїть на 2-му місці
            string line; // допоміжний рядок
            char[] separator = {' '}; // масив
            StringBuilder otvet = new StringBuilder(); // рядок-відповідь

            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                StringBuilder t = new StringBuilder();
             
                while ((line = MyFile.ReadLine()) != null )
                {
                    //Console.WriteLine(line); // друкуємо, що прочитали
                    //виділяємо слова Москаленко А.С.
                    string[] words = line.Split(separator);
                    
                    //Console.WriteLine(words.Length);
                    foreach(string word in words)
                    {
                        //Console.WriteLine(word.Length);
                        t.Append(word[word.Length - 1]);
                    }
                }
                
                Console.WriteLine(t);
                
            }

           
            
        }
    }
}
