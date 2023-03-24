using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameManager gameManager;

    public GameObject addBookTab;

    public float speed = 20.0f;
    public float maxRayDistance = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetGameActive())
        {
            Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            playerRb.MovePosition(transform.position + m_Input * speed * Time.deltaTime);

            if (Input.GetMouseButtonDown(0))
            {
                CheckFront();
            }
        }
    }

    // Casting ray to check what is front of player
    private void CheckFront()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxRayDistance);
        if (hit.collider != null)
        {
            gameManager.SetGameActive(false);
            addBookTab.SetActive(true);
        }
        else
        {
            Debug.Log("nothing");
        }
    }
}
