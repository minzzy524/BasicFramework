using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    class Book
    {

        private string bookname;
        private string author;
        private string publisher;
        private int yearofpublication;

        public Book()
        {
            this.bookname = "C# 교과서";
            this.author = "박준용";

        }

        public Book(string publisher, int yearofpublication)
        { 
            this.bookname = "C# 교과서";
            this.author = "박준용";
            this.publisher = publisher;
            this.yearofpublication = yearofpublication;
        }

        public string Bookname
        {
            get { return this.bookname; } 
        }

        public string Author
        {
            get { return this.author; } 
            set { this.author = value; }
        }

        public string Publisher
        {
            get { return this.publisher; } 
            set { this.publisher = value; }
        }

        public int Yearofpublication
        {
            get { return this.yearofpublication; } 
            set { this.yearofpublication = value; }
        }

        // 두 가지 정보확인 (기능)
        public void BookInfo() // 이름과 색상은 조회 가능
        {
            Console.WriteLine($"Bookname : {bookname}, Publisher : {publisher}, Yearofpublication : {yearofpublication}");
        }
    }
}
