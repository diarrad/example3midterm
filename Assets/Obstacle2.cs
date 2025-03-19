using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Obstacle hit !" + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Obstacle hit ! Game over");
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame

    

    void Update()
    {
        
        }

    }






