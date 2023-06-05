using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float LifeTime;
    void Start()
    {
        Destroy(gameObject,LifeTime);
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            Destroy(gameObject);
    }
    
}
