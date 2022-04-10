using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField]
    private float jumpForce = 1f;
    private bool _jump;
    private bool _isGrounded;
    void Start()
    {
        _jump = false;
        _rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _jump = true;
        }
        if (Input.GetKeyUp("space"))
        {
            _jump = false;
        }
    }

    void FixedUpdate()
    {
        if (_jump & _isGrounded)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        else
        {
            _rb.AddForce(Vector3.down * jumpForce / 6, ForceMode.Impulse);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            _isGrounded = false;
        }
    }
}
