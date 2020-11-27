using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTut : MonoBehaviour
{

    public Transform TargetObject;
    public float rotationSpeed = 1f;

    private Vector3 Offset;

    // Start is called before the first frame update
    //We use this to set offset from the cameras original position
    void Start()
    {

    }
//Every frame, we should update the cameras position in relation to the car's position
    void Update()
    {

    }

}
