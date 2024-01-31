using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public int goalsComplete=0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (goalsComplete == 6)
        {
            print("You Win");
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
