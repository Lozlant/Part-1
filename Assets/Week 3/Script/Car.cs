using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class Car : MonoBehaviour
{
    float forwardInput, steeringInput;
    public float forwardSpeed = 500, steeringSpeed = 200;
    public float maxSpeed=2000;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
        
    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(steeringInput * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * forwardInput * forwardSpeed * Time.deltaTime;
        if(rigidbody.velocity.magnitude < maxSpeed)
        rigidbody.AddForce(force);
    }
    public void Boosts()
    {
        Debug.Log("Boosts");
        Vector2 force = transform.up * forwardInput * forwardSpeed * Time.deltaTime*20;
        rigidbody.AddForce(force);
    }
}
