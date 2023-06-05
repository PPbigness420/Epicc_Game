using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float LifeTime;
    //KULKA REGUOJA SU PLAYER(bug)
    //gal tureti 2 colaiderius?
    
    void Start()
    {
        Destroy(gameObject,LifeTime);
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (!collision.CompareTag("Player"))
        //{
            Destroy(gameObject);
        //}
            
    }
    
}
