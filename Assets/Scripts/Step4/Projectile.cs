using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject explosionParticles;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        var exp = Instantiate(explosionParticles, position, rotation, null);
        exp.SetActive(true);
        Destroy(gameObject);
        Destroy(exp, 5);
    }
}
