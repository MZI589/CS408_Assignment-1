using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float acceleration = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           //rb.AddForce(transform.forward * acceleration);
           gameObject.transform.Translate(Vector3.forward * Time.deltaTime,Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
           gameObject.transform.Translate(Vector3.back * Time.deltaTime,Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
           gameObject.transform.Translate(Vector3.left * Time.deltaTime,Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
           gameObject.transform.Translate(Vector3.right * Time.deltaTime,Space.Self);
        }
    }
}
