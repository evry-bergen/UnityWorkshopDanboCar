using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public UnityEvent ProjectileHit;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "Projectile") return;
        ProjectileHit.Invoke();
        Destroy(gameObject);

    }
}
