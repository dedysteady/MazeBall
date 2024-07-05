using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Live;
    public bool _lolos;
    public bool _getLives;

    private void Start()
    {
        Debug.Log("Start");
        _lolos = false;
        _getLives = false;
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {
            Debug.Log("Flag");
            _lolos = true;
        }
        if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Live--;
            Debug.Log("Bomb");
        }
        if (collision.gameObject.CompareTag("Heart"))
        {
            _getLives = true;
            Debug.Log("Live");
            Destroy(collision.gameObject);
        }
    }
}
