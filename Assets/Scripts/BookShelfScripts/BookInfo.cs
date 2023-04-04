using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInfo
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

    public override string ToString() => $"Name:{Name}\nAuthor:{Author}\nPublisher:{Publisher}\nDate{Date}";
}
