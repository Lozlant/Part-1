using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditor;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float dis;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 direction = collision.contacts[0].normal;
        rigidbody.MovePosition(rigidbody.position+direction * dis * Time.deltaTime);
    }
}
