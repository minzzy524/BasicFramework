using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    class Book2
    {

        static void Main(string[] args)
        {
            Book book = new Book();
            book.BookInfo(); // 입력한 정보대로

            Book book2 = new Book("길벗", 2020); // 내가 원하는대로 설정
            book2.BookInfo();
            Console.WriteLine("Bookname : {0}, Author : {1}, Publisher : {2}, Yearofpublication : {3}", book.Bookname, book.Author, book.Publisher, book.Yearofpublication);
        }
    }
}
