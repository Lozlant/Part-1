using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Lever trigger from" + collision.gameObject);
        door.SetActive(!door.activeInHierarchy);
    }
}
