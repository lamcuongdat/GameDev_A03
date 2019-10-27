using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed = 50f, maxspeed = 3, jumpPow = 220f;
    public Rigidbody2D r2;
    public bool grounded = true, doubleJump=false,
        faceRight=false;
    public Animator anim;
    public int score, health;
    // Start is called before the first frame update
    void Start()
    {
        r2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Flip();
        score = 0;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("onGround", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);
        if (r2.velocity.x > maxspeed)
            r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        if (r2.velocity.x < -maxspeed)
            r2.velocity = new Vector2(-maxspeed, r2.velocity.y);
        if (h >0 && !faceRight)
        {
            Flip();
        }
        if(h<0 && faceRight)
        {
            Flip();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded== true)
            {
                doubleJump = true;
                r2.AddForce(new Vector2(0, 300f));
            }
            else
            {
                if(doubleJump)
                {
                    doubleJump = false;
                    r2.velocity = new Vector2(r2.velocity.x, 0);
                    r2.AddForce(new Vector2(0, 300f));
                }
            }
        }
        
    }
    public void Flip()
    {
        faceRight = !faceRight;
        Vector3 Scale;
        Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}
