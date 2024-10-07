using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float jump;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector2.up * jump);
        if (Input.GetKey(KeyCode.A))
            transform.position +=  speed * Time.deltaTime * Vector3.left;
        if (Input.GetKey(KeyCode.D))
            transform.position += speed * Time.deltaTime * Vector3.right;



    }
}
