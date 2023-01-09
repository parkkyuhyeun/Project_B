using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] public GameObject leftStick;
    [SerializeField] public GameObject rightStick;
    public float angleAdjustment = 0.5f;
    public bool downLeft = false;
    public bool downRight = false;

    private void Start()
    {
        downLeft = false;
        downRight = false;
    }

    private void Update()
    {
        KeyDown();
        ButtonDown();
    }
    private void KeyDown()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            downLeft = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            downLeft = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            downRight = true;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            downRight = false;
        }
    }
    public void ButtonDown()
    {
        if (downLeft)
        {
            leftStick.transform.Rotate(0, 0, 0.3f);
        }
        if (downRight)
        {
            rightStick.transform.Rotate(0, 0, -0.3f);
        }
    }
}
