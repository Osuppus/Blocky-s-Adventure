using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using Cinemachine; 

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    
    public static GameManager instance; 
    int score = 0; 
    int highscore = 0; 

    public Transform respawnPoint;

    public GameObject playerPrefab;

    public CinemachineVirtualCameraBase cam; 

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {   
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        
    }

    public void AddPoint()
    {
        score += 1; 
        scoreText.text = score.ToString() + " POINTS";
        
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        
    }    

   
}
