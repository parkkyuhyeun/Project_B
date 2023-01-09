using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    [SerializeField] GameObject button;
    public bool isDead = false;
    public float time = 10f;
    private void Start()
    {
        isDead = false;
    }
    private void Update()
    {
        TimeManager();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obj"))
        {
            Destroy(collision.gameObject);
            isDead = true;
        }
    }
    public void TimeManager()
    {
        if (isDead)
        {
            Time.timeScale = 0f;
            button.SetActive(true);
            isDead = false;
        }
    }
}
