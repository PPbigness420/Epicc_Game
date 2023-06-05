using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Atributes : MonoBehaviour
{
    public sbyte HP;
    public sbyte Special_Fire;
    
    
    void Awake()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP -= 1;
        if (HP<=0)
        {
            Debug.Log("You Lose!, hit by: "+collision.tag);
        }
    }
}
