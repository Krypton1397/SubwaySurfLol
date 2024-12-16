using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject HighWall;
    [SerializeField] GameObject ShortWall;
    [SerializeField] GameObject WallWithExit;
    [SerializeField] List<GameObject> Walls;
    private void Update()
    {
        
    }

    private void ChoosingSpawn()
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 1)
        {
            Instantiate(HighWall);
            
        }
        if (randomNumber == 2)
        {
            Instantiate(ShortWall);
        }
        if (randomNumber == 3)
        {
            Instantiate(WallWithExit);
        }
        if (randomNumber == 4)
        {
            
        }
    }
}
