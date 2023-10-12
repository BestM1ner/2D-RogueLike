using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCharacter : MonoBehaviour
{
    [SerializeField] double health;

    double armor = 1;
    double enteringDamage = 6;
    bool isDead = false;
    Collider2D characterCollider;

    public bool IsDead
    {
        get
        {
            return isDead;
        }
    }

    void Start()
    {
    }

    void Update()
    {
        if (isDead == true) 
        {
            
        }
    }
    void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            health -= enteringDamage;
        }
    }
    public void Die()
    {
        isDead = true;
    }
}
