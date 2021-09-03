using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // private float x,y;

    public GameObject bulletPrefab;
    
    void Update()
    {
        // Vector3 tmp = GameObject.Find("rocket").transform.position;
        // x = tmp.x;
        // y = tmp.y;
        if(Input.GetKey(KeyCode.LeftArrow)){
            if(transform.position.x>-2.2){
                transform.Translate(-0.1f,0,0);
            }
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x<2.2){
                transform.Translate(0.1f,0,0);
            }
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            if(transform.position.y<4.3){
                transform.Translate(0,0.1f,0);
            }
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            if(transform.position.y>-4.3){
                transform.Translate(0,-0.1f,0);
            }
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bulletPrefab,transform.position,Quaternion.identity);
        }
    }
}
