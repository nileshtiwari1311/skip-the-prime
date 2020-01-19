using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public TextMesh number;
    public int random_number;
    private void Start()
    {
        random_number = Random.Range(2, 100);
        number.text = random_number.ToString();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int x = 0;
            for (int i = 2; i <= random_number/2 ; i++)
            {
                if (random_number % i == 0)
                    x++;
            }

            if (x == 0)
            {
                other.GetComponent<Player>().energy -= random_number;
                Destroy(gameObject);
            }
        }
    }
}
