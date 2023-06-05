using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    
    //Cooldowns
    public Rigidbody2D Projectile_PreFab;
    public float FireRate;
    private float NextFire;
    private bool WhichGun;
    public Transform Fire_PointL;
    public Transform Fire_PointR;

    public float Projectile_Speed;
    private void Awake()
    {
        
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > NextFire)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                NextFire = Time.time + FireRate;
                Fire(true);
                WhichGun = false;
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                NextFire = Time.time + FireRate;
                Fire(false);
                WhichGun = true;
            }
            else
            {
                NextFire = Time.time + FireRate;
                Fire(WhichGun);
                WhichGun = !WhichGun;
            }
        }
    }
    void Fire(bool direction)
    {
        if (direction)
        {
            Rigidbody2D rb = Instantiate(Projectile_PreFab, new Vector2(Fire_PointL.position.x, Fire_PointL.position.y), transform.rotation) as Rigidbody2D;
            rb.GetComponent<Rigidbody2D>().AddForce(transform.up * Projectile_Speed * 5f);
        }
        else
        {
            Rigidbody2D rb = Instantiate(Projectile_PreFab, new Vector2(Fire_PointR.position.x, Fire_PointR.position.y), transform.rotation) as Rigidbody2D;
            rb.GetComponent<Rigidbody2D>().AddForce(transform.up * Projectile_Speed * 5f);
        }
    }
}
