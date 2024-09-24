using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangeScenes : MonoBehaviour   //When you click on the "start game" button, it'll take you to the game level to start your game.
{
   public void GoToSceneTwo()
   {
      SceneManager.LoadScene("SceneTwo"); 
   }

}