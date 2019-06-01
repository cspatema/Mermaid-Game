using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //define the borders as veriables
    public GameObject topBorder;
    public GameObject bottomBorder;
    public GameObject rightBorder;
    public GameObject leftBorder;

    bool canMove = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        canMove = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") && transform.position.y < (topBorder.transform.position.y - 0.5))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.03f);
        }

        if (Input.GetKey("down") && transform.position.y > (bottomBorder.transform.position.y + 0.5))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.03f);
        }

        if (Input.GetKey("left") && transform.position.x > (leftBorder.transform.position.x + 0.5))
        {
            transform.position = new Vector2(transform.position.x - 0.03f, transform.position.y);
        }

        if (Input.GetKey("right") && transform.position.x < (rightBorder.transform.position.x - 0.5))
        {
            transform.position = new Vector2(transform.position.x + 0.03f, transform.position.y);
        }
    }
}
