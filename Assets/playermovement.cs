using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(90, 0, 0));
        }
        
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(new Vector3(-90, 0, 0));
            }
        }
    }
}
