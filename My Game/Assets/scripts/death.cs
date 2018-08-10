using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class death : MonoBehaviour {
    Rigidbody2D rb2d;
    public Score score;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            if(score.score>PlayerPrefs.GetInt("highscore"))
            PlayerPrefs.SetInt("highscore", score.score);
            SceneManager.LoadScene(2);

        }
    }
   
}