using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroybar")
        {
            Destroy(this.gameObject);
        }
    }
}
