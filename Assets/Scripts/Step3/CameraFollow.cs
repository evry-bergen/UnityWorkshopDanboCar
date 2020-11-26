using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform TargetObject;
    public float rotationSpeed = 1f;

    private Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        Offset = TargetObject.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(TargetObject.position - transform.position), rotationSpeed * Time.deltaTime);
       //transform.LookAt(TargetObject);
       transform.position = TargetObject.position - Offset;
    }
}
