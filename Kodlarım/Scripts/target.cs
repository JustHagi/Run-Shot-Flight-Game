using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class target : MonoBehaviour
{
    public bool istarget;
    public float health = 10f;
    public float defaulthealth;
    KillCounter killCounterScript;
    

    private void Start()
    {
        defaulthealth = health;
        killCounterScript = GameObject.Find("Target").GetComponent<KillCounter>();
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 10)
        {
            Die();
        }
    }
    void Die()
    {
        if (istarget)
        {
            health = defaulthealth;
        }
        else
        {
            Destroy(gameObject);
            killCounterScript.AddKill();
        }

    }
    
}
