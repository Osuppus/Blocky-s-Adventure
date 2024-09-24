using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) // Once Player makes contact with goal, the player will be sent to the End scene 
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene("EndScene");
        }
    }

}

