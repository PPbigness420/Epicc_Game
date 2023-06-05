using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move_Fire : MonoBehaviour
{
    //Movement
    private Rigidbody2D rb;
    public float speed;
    //Fire
    public Rigidbody2D Projectile_PreFab;
    public float FireRate;
    private float NextFire;
    public Transform Fire_Point;
    public float Projectile_Speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        rb.velocity = new Vector2(0f,-1f*speed);
        //Fire
        if (Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;
            Fire();
        }
    }
    void Fire()
    {   
            Rigidbody2D rb = Instantiate(Projectile_PreFab, new Vector2(Fire_Point.position.x, Fire_Point.position.y), transform.rotation) as Rigidbody2D;
            rb.GetComponent<Rigidbody2D>().AddForce(transform.TransformDirection(Vector2.down) *-1f *Projectile_Speed * 5f);
    }
}
