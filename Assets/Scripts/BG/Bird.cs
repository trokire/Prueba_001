using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float speed = 1f; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        if (transform.position.x > 10f) 
        {
          speed = speed * -1;     
        }
        if (transform.position.x < -10f) 
        {
          speed = speed * -1;
        }
    }
}
