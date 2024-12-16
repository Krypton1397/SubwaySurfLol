using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] int jumpForce = 175;
    private float positionX = -15.79f;
    private float positionY = 2.9778f;
    private float positionZ = -1.3067f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        MoveMechanic();
    }

    private void MoveMechanic()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(positionX, positionY, positionZ + 2.6f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(positionX, positionY, positionZ - 2.6f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(positionX, positionY, positionZ = -1.3067f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Time.timeScale = 0;
        }
    }
}
