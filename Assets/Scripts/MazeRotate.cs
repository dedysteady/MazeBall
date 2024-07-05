using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotate : MonoBehaviour
{
    public bool _isActive = true;
    // Start is called before the first frame update
    void Start()
    {
        _isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isActive == true)
        {
            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = rotation;
        }
        if (_isActive == false)
        {

        }
    }
}
