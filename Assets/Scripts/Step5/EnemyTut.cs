using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyTut : MonoBehaviour
{
    public UnityEvent ProjectileHit;

    //When the enemy collides with a projectile it should invoke an event and destroy itself
    void OnCollisionEnter(Collision collision)
    {

    }
}
