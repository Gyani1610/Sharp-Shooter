using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 

public class UI_Manager : MonoBehaviour
{
    GameObject[] enemySpawner;
    //public int score;
    public Text scoreText;
    int spawnerCount = 0;
    void Start()
    {
        enemySpawner = GameObject.FindGameObjectsWithTag("EnemySpawner");
        spawnerCount = enemySpawner.Length;
    }

 

    // Update is called once per frame
    void Update()
    {
        int scoreCount=0;
        for(int i=0;i<spawnerCount;i++)
        {
            scoreCount = scoreCount + enemySpawner[i].GetComponent<EnemySpawner>().Score;
        }
        scoreText.text = scoreCount.ToString();
       
         if(scoreCount>PlayerPrefs.GetInt("highestscore"))
            PlayerPrefs.SetInt("highestscore", scoreCount);
       
    
           
    
    }
    
}
