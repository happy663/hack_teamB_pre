using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate (0, 0.2f, 0);

        if (transform.position.y > 5) {
            Destroy (gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Stone"))
        {
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            Destroy(coll.gameObject);
            Destroy(gameObject);
            // Destroy(BulletController.explosionPrefab);
        }
    }
}
