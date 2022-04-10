using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsideScript : MonoBehaviour
{
    private Rigidbody _rb;
    private Transform _transform;
    [SerializeField]
    private float speed = 10f;
    private bool pushedRB = false;


    private void Awake()
    {
        _rb = this.GetComponent<Rigidbody>();
        _transform = this.GetComponent<Transform>();
    }

    void Update()
    {
        if (this.transform.position.z <= 8)
        {
            _transform.Translate(0, 0, 5 * Time.deltaTime);
        }
    }

    /*
    void FixedUpdate()
    {
        if(!pushedRB)
        {
            Debug.Log("We tried pushing!");
           _rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
            pushedRB = true;
        }
    }
    */
}
