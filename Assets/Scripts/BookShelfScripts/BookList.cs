using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookList : MonoBehaviour
{
    List<BookInfo> bookList = new List<BookInfo>();

    // Add bookInfo to list
    public void AddBookInfo(string name, string author, string publisher, string date)
    {
        BookInfo newBook = new BookInfo(name, author, publisher, date);
        bookList.Add(newBook);
        Debug.Log($"Added new book {newBook}");
    }

    public List<BookInfo> GetBookInfos()
    {
        return bookList;
    }

    // return indidual bookInfo
    public BookInfo GetBookInfo(string name)
    {
        foreach (var book in bookList)
        {
            if (book.Name == name)
            {
                return book;
            }
        }
        return null;
    }
}
