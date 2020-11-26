using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CarController : MonoBehaviour
{
    public float thrust = 15f;
    public float torque = 20f;
    public Animator animator;
    [SerializeField]
    private bool _isGrounded;
    private Rigidbody _rigidBody;

    public UnityEvent FireEvent;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        ResetCarPosition();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireEvent.Invoke();
        }
    }
//FixedUpdate runs fixed to the physics frame
    void FixedUpdate()
    {
        CarControls();
        checkIfGrounded();
        animator.SetFloat("animSpeed", _rigidBody.velocity.magnitude);
    }

    private void CarControls()
    {
        if (!_isGrounded) return;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidBody.AddForce(transform.forward * thrust);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidBody.AddTorque(transform.up * -1  * torque);
            Debug.Log("torque");
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _rigidBody.AddForce(transform.forward * -1 * thrust);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody.AddTorque(transform.up  * torque);
            Debug.Log("torque");

        }
    }

    public void checkIfGrounded()
    {
        int layerMask = 1 << 10; //Layer 10 is "Ground"
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 2, layerMask))
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            _isGrounded = true;
        }
        else
        {
            _isGrounded = false;
        }
    }

    private void ResetCarPosition()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
        }
    }
}
