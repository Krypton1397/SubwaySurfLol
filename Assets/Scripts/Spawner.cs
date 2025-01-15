using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

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
            ChoosingSpawn(SpawnerMiddle);
            ChoosingSpawn(SpawnerLeft);
            ChoosingSpawn(SpawnerRight);
            Walls.Clear();
        }
    }

    private void ChoosingSpawn(Transform spawnPosition)
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 1)
        {
            if (Walls.Contains(HighWall))
            {
                return;
            }
            Instantiate(HighWall,spawnPosition);
            Walls.Add(HighWall);
        }
        if (randomNumber == 2)
        {
            if (Walls.Contains(ShortWall))
            {
                return;
            }
            Instantiate(ShortWall,spawnPosition);
            Walls.Add(ShortWall);
        }
        if (randomNumber == 3)
        {
            if (Walls.Contains(WallWithExit))
            {
                return;
            }
            Instantiate(WallWithExit,spawnPosition);
            Walls.Add(WallWithExit);
        }
    }
}
