using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour
{
    private Button cancelButton;
    private TabManager parentTab;

    // Start is called before the first frame update
    void Start()
    {
        parentTab = transform.parent.gameObject.GetComponent<TabManager>();
        cancelButton = GetComponent<Button>();
        cancelButton.onClick.AddListener(CloseTab);
    }

    void CloseTab()
    {
        parentTab.CloseTab();
    }
}
