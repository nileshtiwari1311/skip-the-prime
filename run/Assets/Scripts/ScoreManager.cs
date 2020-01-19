using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    public bool flag;
    private void Update()
    {
        scoreDisplay.text = "Score : " + score.ToString();
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle") && flag)
        {
            score++;
            Debug.Log(score);
        }
    }

}
