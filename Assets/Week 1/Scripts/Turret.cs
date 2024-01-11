using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float speed = 30f;
    public GameObject missilePrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward,direction * speed * Time.deltaTime);
    }
}

