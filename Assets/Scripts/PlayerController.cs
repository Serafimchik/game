using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertInput = Input.GetAxis("Vertical");
        float horInput = Input.GetAxis("Horizontal");
        
        if (vertInput > 0)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        if (vertInput < 0)
        {
            transform.Translate(-Vector2.up * Time.deltaTime * speed);
        }

        if (horInput > 0)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if (horInput < 0)
        {
            transform.Translate(-Vector2.right * Time.deltaTime * speed);
        }
    }
}
