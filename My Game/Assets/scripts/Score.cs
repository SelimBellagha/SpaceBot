using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private float timer;
    public int score;
    public Text ScoreText;

    void Update()
    {

        timer += Time.deltaTime;
        if (timer > 1f)
        {

            score ++;

            ScoreText.text = score.ToString();

            timer = 0;
        }
        
    }
}
