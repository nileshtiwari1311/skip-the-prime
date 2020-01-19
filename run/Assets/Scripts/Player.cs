using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float Yincrement;
    public float maxY;
    public float minY;

    private Vector2 targetPos;

    public int energy;

    public ScoreManager scm;

    
    public Text energyDisplay;
    public Text Game_Over;

    public GameObject gameOver;

    bool isScoreUpdate = true;

    private void Update()
    {
        energyDisplay.text = "Energy : " + energy.ToString();
        if(energy <= 0)
        {
           
            gameOver.SetActive(true);
            Destroy(gameObject);
            Game_Over.enabled = !Game_Over.enabled;
            isScoreUpdate = false;

            
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY && transform.position.y % 7 == 0)
        {
            
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY && transform.position.y % 7 == 0)
        {
            
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

        scm.flag = isScoreUpdate;
    }
}
