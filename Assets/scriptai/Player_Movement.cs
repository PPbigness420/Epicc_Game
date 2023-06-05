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

        //jei 2d movemnt
        //if (transform.position.x>=5f&&x<0f   || transform.position.x <= -5f && x > 0f)
        //{
        //    rb.velocity = new Vector2(x * speedx, 0f);
        //}
        //else if (transform.position.y >= 5f && y < 0 || transform.position.y <= -5f&&y>0)
        //{
        //    rb.velocity = new Vector2(0f, y * speedy);
        //}
        //else if (transform.position.x <= -5f|| transform.position.x >= 5f&&transform.position.y<5f&&transform.position.y<-5.5f)
        //{
        //    rb.velocity = new Vector2(0f, y * speedy);
        //}
        //else if (transform.position.y >= 5f|| transform.position.y <= -5f)
        //{
        //    rb.velocity = new Vector2(x * speedx,0f);
        //}
        //else
        //{
        //    rb.velocity = new Vector2(x * speedx, y * speedy);
        //}


        
        //1d movemnet(su borders)
         if (transform.position.x >= 5f && x < 0f || transform.position.x <= -5f && x > 0f)
        {
            rb.velocity = new Vector2(x * speedx, 0f);
        }
        else if (transform.position.x >= 5f || transform.position.x <= -5f)
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        else
        {
            rb.velocity = new Vector2(x * speedx, 0f);
        }
            
        
        
        
    }
}
