using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Atributes : MonoBehaviour
{
    private int HP;
    public int Max_HP;
    public int Special_Fire;
    void Awake()
    {
        HP = Max_HP;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
