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
    [SerializeField] Transform SpawnerRight;
    [SerializeField] Transform SpawnerLeft;
    [SerializeField] Transform SpawnerMiddle;
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 2;
            Debug.Log("SpawnBlock");
            ChoosingSpawnLeft();
            ChoosingSpawnMiddle();
            ChoosingSpawnRight();
            Walls.Clear();
        }
    }

    private void ChoosingSpawnRight()
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 1)
        {
            if (Walls.Contains(HighWall))
            {
                return;
            }
            Instantiate(HighWall,SpawnerRight);
            Walls.Add(HighWall);
        }
        if (randomNumber == 2)
        {
            if (Walls.Contains(ShortWall))
            {
                return;
            }
            Instantiate(ShortWall,SpawnerRight);
            Walls.Add(ShortWall);
        }
        if (randomNumber == 3)
        {
            if (Walls.Contains(WallWithExit))
            {
                return;
            }
            Instantiate(WallWithExit,SpawnerRight);
            Walls.Add(WallWithExit);
        }
    }
    private void ChoosingSpawnMiddle()
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 1)
        {
            if (Walls.Contains(HighWall))
            {
                return;
            }
            Instantiate(HighWall,SpawnerMiddle);
            Walls.Add(HighWall);
        }
        if (randomNumber == 2)
        {
            if (Walls.Contains(ShortWall))
            {
                return;
            }
            Instantiate(ShortWall,SpawnerMiddle);
            Walls.Add(ShortWall);
        }
        if (randomNumber == 3)
        {
            if (Walls.Contains(WallWithExit))
            {
                return;
            }
            Instantiate(WallWithExit,SpawnerMiddle);
            Walls.Add(WallWithExit);
        }
    }
    private void ChoosingSpawnLeft()
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 1)
        {
            if (Walls.Contains(HighWall))
            {
                return;
            }
            Instantiate(HighWall,SpawnerLeft);
            Walls.Add(HighWall);
        }
        if (randomNumber == 2)
        {
            if (Walls.Contains(ShortWall))
            {
                return;
            }
            Instantiate(ShortWall,SpawnerLeft);
            Walls.Add(ShortWall);
        }
        if (randomNumber == 3)
        {
            if (Walls.Contains(WallWithExit))
            {
                return;
            }
            Instantiate(WallWithExit,SpawnerLeft);
            Walls.Add(WallWithExit);
        }
    }
}
