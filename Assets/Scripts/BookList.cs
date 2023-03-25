using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookList : MonoBehaviour
{
    List<BookInfo> bookInfos = new List<BookInfo>();

    struct BookInfo
    {
        public BookInfo(string name, string author, string publisher, string date)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            Date = date;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Date { get; set; }

        public override string ToString() => $"Name:{Name}, Author:{Author}, Publisher:{Publisher}, Date{Date}";
    }

    // Add bookInfo to list
    public void AddBookInfo(string name, string author, string publisher, string date)
    {
        BookInfo newBook = new BookInfo(name, author, publisher, date);
        bookInfos.Add(newBook);
        Debug.Log($"Added new book {newBook}");
    }
}
