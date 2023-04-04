using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookInfoButtonCreate : MonoBehaviour
{
    [SerializeField] GameObject bookInfoButton;
    [SerializeField] BookList bookList;

    private void OnEnable()
    {
        CreateButtons(bookList.GetBookInfos());
    }

    public void CreateButtons(List<BookInfo> bookInfos)
    {
        int i = 0;

        foreach (var book in bookInfos)
        {
            var instanceButton = Instantiate<GameObject>(bookInfoButton, transform);
            instanceButton.name = "BookButton" + i++;
            instanceButton.transform.localScale = new Vector3(1f, 1f, 1f);
            instanceButton.GetComponent<BookInfoDisplay>().SetBookInfo(book);
            instanceButton.GetComponentInChildren<TMP_Text>().text = $"{book.Name}";
        }
    }
}
