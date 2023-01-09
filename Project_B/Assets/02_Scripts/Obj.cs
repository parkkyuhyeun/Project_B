using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    public bool isGround = false;
    void Start()
    {
        isGround = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Square")
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }
}
