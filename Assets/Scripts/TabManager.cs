using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // When open new tab, we set gameActive to false
    public void OpenTab()
    {
        gameObject.SetActive(true);
        gameManager.SetGameActive(false);
    }

    // When close current tab, we set gameActive to true
    public void CloseTab()
    {
        gameObject.SetActive(false);
        gameManager.SetGameActive(true);
    }
}
