using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Book book = new Book("Hello I am from book");
            CopyBook cp = new CopyBook("Hello i am from copybook");
            Journal jr = new Journal("Hello i am from journal");
            Notebook nt = new Notebook("Hello i am from notebook");
            book.GetContent();
            jr.GetContent();
            nt.GetText();
            cp.GetText();

            WriteLine("\nWrite a text in to notebook");

            nt.SetText();
            nt.GetText();

            WriteLine("\nWrite a text in to notebook");
            
            cp.SetText();
            cp.GetText();
        }
    }

    public class Book
    {
        private string Content;

        public Book(string content = null)
        {
            Content = content;
        }

        public string Content1 { get => Content; set => Content = value; }

        public void GetContent()
        {
            WriteLine(Content);
        }


    }
    public class Journal
    {
        private string Content;

        public Journal(string content = null)
        {
            Content = content;
        }

        public string Content1 { get => Content; set => Content = value; }

        public void GetContent()
        {
            WriteLine(Content);
        }
    }

    public class Notebook
    {
        private string readContent;
        private string writeContent;

        public Notebook(string readcontent = null)
        {
            readContent = readcontent;
        }

        public string ReadContent { get => readContent; set => readContent = value; }
        public string WriteContent { get => writeContent; set => writeContent = value; }

        public void GetText()
        {
            WriteLine(readContent);
            
        }

        public void SetText()
        {
           writeContent = ReadLine();
           readContent += "\n" + writeContent + "\n";
        }
    }

    public class CopyBook
    {
        private string readContent;
        private string writeContent;


        public CopyBook(string readcontent = null)
        {
            readContent = readcontent;
        }

        public string ReadContent { get => readContent; set => readContent = value; }
        public string WriteContent { get => writeContent; set => writeContent = value; }

        public void GetText()
        {
            WriteLine(readContent);
            
        }

        public void SetText()
        {
            writeContent = ReadLine();
            readContent += "\n" + writeContent + "\n";
        }

    }

}
