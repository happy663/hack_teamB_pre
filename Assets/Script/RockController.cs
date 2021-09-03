using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    // public static bool out; 

    void Start () {
        this.fallSpeed = 0.03f + 0.05f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
        // out = true;
    }

    void Update()
    {
        transform.Translate( 0, -fallSpeed, 0 ,Space.World);
        transform.Rotate(0,0,rotSpeed);

        if(transform.position.y < -5.5f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Player"))
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            // Instantiate(BulletController.explosionPrefab,transform.position,Quaternion.identity);
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
