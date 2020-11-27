using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTut : MonoBehaviour
{
    public GameObject explosion;

    //When the projectile with something, anything, it should find out where it crashed and create an explosion there, and destroy itself and the xplosion after the particle system is done
    void OnCollisionEnter(Collision collision)
    {


    }

}
