using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] public GameObject leftStick;
    [SerializeField] public GameObject rightStick;

    private float rotationSpeed = 150f;
    private float angleAdjustment = 50f;
    private float leftHandleRotation = -15f;
    private float rightHandleRotation = 15f;

    public bool downLeft = false;
    public bool downRight = false;

    private void Start()
    {
        downLeft = false;
        downRight = false;
    }

    private void Update()
    {
        ButtonDown();
    }
    public void LButtonDown()
    {
        downLeft = true;
    }
    public void LButtonUp()
    {
        downLeft = false;
    }
    public void RButtonDown()
    {
        downRight = true;
    }
    public void RButtonUp()
    {
        downRight = false;
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
    public void ResetQuaternion()
    {
        leftHandleRotation = -15f;
        rightHandleRotation = 15f;
    }
}
