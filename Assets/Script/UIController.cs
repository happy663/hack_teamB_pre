using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    
     int score = 0;
     GameObject scoreText;


     public void AddScore(){
         this.score += 10;
     }
     void Start(){
            // this.scoreText = GameObject.Find("Score")
             }
     void Update()
    {
        // scoreText.GetComponent<Text> ().text = "Score" + score.ToString("D4")
         }
}
