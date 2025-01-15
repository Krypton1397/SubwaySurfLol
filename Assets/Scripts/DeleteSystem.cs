using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSystem : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(collision.gameObject);
        }
    }
}
