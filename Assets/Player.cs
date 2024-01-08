using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchpos.x < 0 )
            {
                rb.AddForce( Vector2.left * moveSpeed );
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed );
            }




        }
        else
        {
            rb.velocity = Vector2.zero;

        }
    }
}
