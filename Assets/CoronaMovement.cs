using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaMovement : MonoBehaviour
{
    public float jumpSpeed = 2;
    public float speed = 2;


    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount <= 0) return;
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Hello");
                GetComponent<AudioSource>().Play();
                GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            }
        
    }

    
}
