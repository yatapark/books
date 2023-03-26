using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    private GameManager gameManager;

    // if player push ESC, close tab and gameActivate
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseTab();
            gameManager.SetGameActive(true);
        }
    }

    // When open new tab, we set gameActive to false
    public void OpenTab()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameObject.SetActive(true);
        gameManager.SetGameActive(false);
    }

    // When close current tab, we set gameActive to true
    public void CloseTab()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameObject.SetActive(false);
        gameManager.SetGameActive(true);
    }
}
