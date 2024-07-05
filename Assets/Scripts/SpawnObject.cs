using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnObject;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPosition = new Vector3(2, 2, 0);
    }
}
