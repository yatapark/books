using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float speed = 20.0f;
    public float maxRayDistance = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerRb.MovePosition(transform.position + m_Input * speed * Time.deltaTime);

        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxRayDistance);
            if (hit.collider == null)
            {
                Debug.Log("nothing");
            }
            else if (hit.collider.CompareTag("Furniture"))
            {
                Debug.Log("hit");
            }
        }
    }
}
