using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterText : MonoBehaviour
{
    public TMP_InputField[] inputFields;
    public BookList bookList;

    public void AddToBookList()
    {
        bookList.AddBookInfo(inputFields[0].text, inputFields[1].text, inputFields[2].text, inputFields[3].text);
    }
}
