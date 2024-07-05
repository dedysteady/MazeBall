using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MazeRotateInput : MonoBehaviour
{
    public float speedRotation;
    public bool RotateLeft;
    public bool RotateRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RotateLeft)
        {
            RotateKiri();
        }
        if (RotateRight)
        {
            RotateKanan();
        }
    }

    public void RightUp()
    {
        RotateRight = false;
    }

    public void LeftUp()
    {
        RotateLeft = false;
    }

    public void RightDown()
    {
        RotateRight = true;
    }

    public void LeftDown()
    {
        RotateLeft = true;
    }

    private void RotateKanan()
    {
        transform.Rotate(0, 0, -speedRotation * Time.deltaTime);
    }

    private void RotateKiri()
    {
        transform.Rotate(0, 0, speedRotation * Time.deltaTime);
    }
}
