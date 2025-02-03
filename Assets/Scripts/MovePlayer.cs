using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] int jumpForce = 150;
    [SerializeField] private GameObject loseWindow;
    private float positionX = -15.79f;
    private float positionY = 2.9778f;
    private float positionZ = -1.3067f;
    private Rigidbody rb;
    private float timer = 2;
    private bool CanMove = true;
    private void Start()
    {
        CanMove = true;
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        MoveMechanic();
        timer -= Time.deltaTime;
    }

    private void MoveMechanic()
    {
        if (CanMove == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (timer < 0)
                {
                    rb.AddForce(Vector3.up * jumpForce);
                    timer = 2;
                }
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WallMove>())
        {
            CanMove = false;
            loseWindow.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
