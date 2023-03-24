using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddBookButton : MonoBehaviour
{
    private Button addBookButton;
    private TabManager parentTab;

    // Start is called before the first frame update
    void Start()
    {
        parentTab = transform.parent.gameObject.GetComponent<TabManager>();
        addBookButton = GetComponent<Button>();
        addBookButton.onClick.AddListener(AddBookInfo);
    }

    // Adding new book info to database
    void AddBookInfo()
    {
        Debug.Log("Added!");
        parentTab.CloseTab();
    }
}
