using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    private float rotationSpeed = 200f;
    private float angleAdjustment = 50f;

    [SerializeField] public GameObject leftStick;
    [SerializeField] public GameObject rightStick;

    float leftHandleRotation = -15f;
    float rightHandleRotation = 15f;

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
            leftHandleRotation += Time.deltaTime * rotationSpeed;
        else
            leftHandleRotation -= Time.deltaTime * angleAdjustment;
        if (downRight)
            rightHandleRotation -= Time.deltaTime * rotationSpeed;
        else
            rightHandleRotation += Time.deltaTime * angleAdjustment;

        leftHandleRotation = Mathf.Clamp(leftHandleRotation, -15f, 30f);
        rightHandleRotation = Mathf.Clamp(rightHandleRotation, -30, 15);

        leftStick.transform.rotation = Quaternion.AngleAxis(leftHandleRotation, Vector3.forward);
        rightStick.transform.rotation = Quaternion.AngleAxis(rightHandleRotation, Vector3.forward);
    }
}
