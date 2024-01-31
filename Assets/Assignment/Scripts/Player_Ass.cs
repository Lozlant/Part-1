using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_Ass : MonoBehaviour
{
    Vector2 direction;
    public float speed, steeringSpeed;
    float steeringInput;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) direction = new Vector2(Input.GetAxis("Horizontal"), 0);
        else direction = new Vector2(0, Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.Q)) steeringInput = 1f;
        else if (Input.GetKey(KeyCode.E)) steeringInput = -1f;
        else steeringInput = 0;


    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steeringInput * steeringSpeed * Time.deltaTime);
        rigidbody.MovePosition(rigidbody.position + direction * speed * Time.deltaTime);
    }
}
