using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : MonoBehaviour
{
    public float runSpeed = 10.0f;    

    private Rigidbody2D body;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, 0);   
    }
}
