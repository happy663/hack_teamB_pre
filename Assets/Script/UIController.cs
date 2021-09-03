using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;

    public GameObject rockPrefab;

    public void GameOver(){
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        GameObject.Find("Director").GetComponent<RockGenerator>().Stop();

    }

    public void AddScore(){
        this.score += 10;
    }
     void Start(){
            this.scoreText = GameObject.Find("Score");
            this.gameOverText = GameObject.Find("GameOver");
             }
     void Update()
    {
        scoreText.GetComponent<Text> ().text = "Score" + score.ToString("D4");
         }
}

