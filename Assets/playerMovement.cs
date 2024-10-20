using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpforce;
    float score;
   
    public Text scoreTxt;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score;


        if(Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * jumpforce;
        }
    }

    private void OntriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "point")
        {
            score++;
        }

        if(collision.gameObject.tag == "batu")
        {
            Destroy(gameObject);
        }
    }

}
