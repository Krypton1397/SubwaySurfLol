using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject HighWall;
    [SerializeField] GameObject ShortWall;
    [SerializeField] GameObject WallWithExit;
    [SerializeField] float timer = 2;
    [SerializeField] List<GameObject> Walls = new List<GameObject>();
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 2;
            Debug.Log("SpawnBlock");
            ChoosingSpawn();
        }
    }

    private void ChoosingSpawn()
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 1)
        {
            if (Walls.Contains(HighWall))
            {
                return;
            }
            Instantiate(HighWall, gameObject.transform.position, gameObject.transform.rotation);
            Walls.Add(HighWall);
        }
        if (randomNumber == 2)
        {
            if (Walls.Contains(ShortWall))
            {
                return;
            }
            Instantiate(ShortWall,gameObject.transform.position, gameObject.transform.rotation);
            Walls.Add(ShortWall);
        }
        if (randomNumber == 3)
        {
            if (Walls.Contains(WallWithExit))
            {
                return;
            }
            Instantiate(WallWithExit,gameObject.transform.position, gameObject.transform.rotation);
            Walls.Add(WallWithExit);
        }
        Walls.Clear();
    }
}
