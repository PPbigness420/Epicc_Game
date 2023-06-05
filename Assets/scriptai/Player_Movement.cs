using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //Fizikos
    private Rigidbody2D rb;
    //Speed
    public float speedx;
    public float speedy;
    //Sprites
    private SpriteRenderer sp;
    public Sprite spr_left;
    public Sprite spr_def;
    public Sprite spr_right;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if (x > 0)
        {
            sp.sprite = spr_right;
        }
        else if (x < 0)
        {
            sp.sprite = spr_left;
        }
        else
        {
            sp.sprite = spr_def;
        }


        //1 budas
        //gameObject.transform.position = new Vector2(transform.position.x +(x*speedx),transform.position.y+(y*speedy));
        //2budas no workey corectly
        rb.velocity = new Vector2(x * speedx, y * speedy);
        
    }
}
