using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Atributes : MonoBehaviour
{
    public int HP;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP -= 1;

        if (HP <= 0)
        {
            Destroy(gameObject);
            
        }
        else
        {
            
        }
    }
}
