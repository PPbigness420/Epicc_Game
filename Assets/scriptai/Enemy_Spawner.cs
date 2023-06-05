using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public Rigidbody2D Enemy;
    public float SpawnRate;
    private float NextSpawn;

    void Start()
    {
        
    }
    void Update()
    {
        if (Time.time > NextSpawn)
        {
            NextSpawn = Time.time + SpawnRate;
            Rigidbody2D rb = Instantiate(Enemy, new Vector2(transform.position.x, transform.position.y - 1f), transform.rotation) as Rigidbody2D;
            rb.GetComponent<Rigidbody2D>().AddForce(transform.up * -5f);
        }
        
    }
}
