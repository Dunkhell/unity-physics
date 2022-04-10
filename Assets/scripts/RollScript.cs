using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollScript : MonoBehaviour
{
    
    bool rollRight;
    private Rigidbody _rb;
    [SerializeField]
    private float speed = 5f;


    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            rollRight = false;
        }
        if (Input.GetKeyUp("d"))
        {
            rollRight = true;
        }
    }

    private void FixedUpdate()
    {
        if(rollRight)
        {
            _rb.AddForce(Vector3.right * speed, ForceMode.Force);
            //_rb.AddForce(Vector3.up * speed, ForceMode.Acceleration);
        }
        if (!rollRight)
        {
            _rb.AddForce(Vector3.left * speed, ForceMode.Force);
            //_rb.AddForce(Vector3.down * speed, ForceMode.Acceleration);
        }
    }
}
