using UnityEngine;

public class Monster : MonoBehaviour
{
    public Transform Player;
    public float speed = 3f;
    

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            transform.LookAt(Player);
            
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed*Time.deltaTime);
            
        }
    }
}
