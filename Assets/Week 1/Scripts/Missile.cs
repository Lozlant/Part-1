using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed=10f;
    Rigidbody2D rigidbody;
    Vector2 direction = new Vector2(10,0);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Missile hit something");
        Destroy(gameObject);
    }
  
}
