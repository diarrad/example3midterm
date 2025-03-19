using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;
    public float currentSpeed;

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

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    
}
