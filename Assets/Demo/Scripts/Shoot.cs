using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("Round"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Round"))
        {
            Destroy(gameObject);
        }
    }
}
