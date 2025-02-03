using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private PlayerScore player;
    private Text textScore;
    private int score;

    private void Start()
    {
        textScore = GetComponent<Text>();
    }
    private void Update()
    {
        if (score != player.GetScore())
        {
            score = player.GetScore();
            textScore.text = "Score: " + score.ToString();
        }
    }
}
