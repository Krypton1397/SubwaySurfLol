using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

}
