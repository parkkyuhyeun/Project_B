using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    [SerializeField] public GameObject leftStick;
    [SerializeField] public GameObject rightStick;
    public bool isDead = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obj"))
        {
            isDead = true;
            FindObjectOfType<Timer>().TimerReset();
            FindObjectOfType<Wingyu>().Win();
            FindObjectOfType<Flipper>().ResetQuaternion();
            isDead = false;
            Destroy(collision.gameObject);
        }
    }
    
}
