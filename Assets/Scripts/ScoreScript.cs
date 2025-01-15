using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text textScore;
    private int score;
    private float timer = 2;

    private void Start()
    {
        textScore = GetComponent<Text>();
        score -= 2;
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
        textScore.text = "Score : " + score.ToString();
    }
}
