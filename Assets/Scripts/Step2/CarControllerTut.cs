using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CarControllerTut : MonoBehaviour
{
    public float thrust = 40f;
    public float torque = 35f;
    public bool isGrounded;
    private Rigidbody _rigidBody;

    public UnityEvent OnSpace;

    // Start is called before the first frame update
    void Start()
    {
    }


// Update is called once per frame
    void Update()
    {


    }
    //FixedUpdate runs fixed to the physics frame

    void FixedUpdate()
    {

    }
/*Controls for the car to drive back and forth and rotate*/
    private void CarControls()
    {
    }

/*Used for checking if the car is on the ground, sets a field variable bool isGrounded to false if not*/
    private void CheckIfGrounded()
    {

    }
    /*If the car flips, this resets the caræs rotation*/
    private void ResetCarPosition()
    {

    }


}
