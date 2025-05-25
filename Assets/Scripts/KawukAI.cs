using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KawukAI : MonoBehaviour
{
    public Transform target;
    public float speed = 1.5f;
    public int damage = 2;

    void Update()
    {
        if (target == null) return;

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 1f)
        {
            target.GetComponent<Grave>()?.TakeDamage(damage);
        }
    }
}
