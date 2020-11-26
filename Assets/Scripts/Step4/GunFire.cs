using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource FireAudioSource;
    public AudioClip FireAudioClip;


    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        spawnedBullet.transform.rotation = barrel.rotation;
        FireAudioSource.PlayOneShot(FireAudioClip);
        Destroy(spawnedBullet, 2);
    }


}
