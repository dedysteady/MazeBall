using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col_1 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime*20);
    }
}
