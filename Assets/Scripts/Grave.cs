using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour
{
    public int health = 5;
    public GameObject jumpscareEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerJumpscare();
        }
    }

    void TriggerJumpscare()
    {
        if (jumpscareEffect != null)
        {
            Instantiate(jumpscareEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject); // atau aktifkan animasi hancur
    }
}
