using UnityEngine;
using UnityEngine.SceneManagement;


public class YouWin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the player hit space. . .
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //Then load the 'HelloKitty' scene
            SceneManager.LoadScene("HelloKittycoinz");
        } 
    }
}
