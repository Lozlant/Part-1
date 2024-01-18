using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laucher : MonoBehaviour
{   
    public GameObject missilePrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from" + collision.gameObject);
        Instantiate(missilePrefab, spawn.position, spawn.rotation);
    }
}
