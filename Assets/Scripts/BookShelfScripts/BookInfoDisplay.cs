using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BookInfoDisplay : MonoBehaviour
{
    private BookInfo bookInfo;

    // Add listener when the button push
    private void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(DisplayBookInfo);
    }

    // Bind each button and each bookInfo
    public void SetBookInfo(BookInfo bookInfo)
    {
        this.bookInfo = bookInfo;
    }

    // Display bookInfo to Information window
    private void DisplayBookInfo()
    {
        Debug.Log($"{bookInfo}");
        transform.parent.parent.Find("Information").GetComponentInChildren<TMP_Text>().text = $"{bookInfo}";
    }

    // When disable destroy
    private void OnDisable()
    {
        Destroy(gameObject);
    }
}
