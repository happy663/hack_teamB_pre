using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    void Start () {
        this.fallSpeed = 0.03f + 0.05f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
    }

    void Update()
    {
        transform.Translate( 0, -fallSpeed, 0 ,Space.World);
        transform.Rotate(0,0,rotSpeed);

        if(transform.position.y < -5.5)
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
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
