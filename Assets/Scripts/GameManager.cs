using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetGameActive()
    {
        return isGameActive;
    }

    public void SetGameActive(bool activeOrNot)
    {
        isGameActive = activeOrNot;
    }
}
