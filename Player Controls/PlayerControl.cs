using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Player Movement
    public float speed;
    public float jump;
    private float move;

    public Rigidbody2D rb;
    //bool canJump;

    // Start is called before the first frame update
    void Start()
    {
       //bool canJump = rb.velocity.y < .1f && rb.velocity.y > -.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement (left/right)
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        //Player Movement (Jump with Up Arrow)
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            rb.AddForce(new Vector2(rb.velocity.x, jump));

           // if (canJump) {
                //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            //}

            
        }
    } 

}
