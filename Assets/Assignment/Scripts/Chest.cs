using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditor;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject set;
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
        
        if (collision.CompareTag("Goal"))
        {    
            set.GetComponent<Restart>().goalsComplete++;
            Debug.Log("Trigger  " + set.GetComponent<Restart>().goalsComplete);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            set.GetComponent<Restart>().goalsComplete--;

        }
    }
}
