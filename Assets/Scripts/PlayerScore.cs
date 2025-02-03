using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
    private int score;
    private float timer = 2;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 2;
            ChangeScore(1);
        }
    }

    private void ChangeScore(int numberForChange)
    {
        score += numberForChange;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<CoinMove>())
        {
            Destroy(collision.gameObject);
            ChangeScore(1);
        }
    }
    public int GetScore()
    {
        return score;
    }
}
