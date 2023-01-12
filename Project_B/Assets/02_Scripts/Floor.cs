using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    [SerializeField] public GameObject leftStick;
    [SerializeField] public GameObject rightStick;
    [SerializeField] public GameObject gameOverPanel;
    [SerializeField] LifeManager lifeM;
    public bool isDead = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obj"))
        {
            lifeM.life--;
            lifeM.UpdateLifeIcon(lifeM.life);
            if (lifeM.life != 0)
            {
                isDead = true;
                FindObjectOfType<Timer>().TimerReset();
                FindObjectOfType<Wingyu>().Win();
                FindObjectOfType<Flipper>().ResetQuaternion();
                isDead = false;
                Destroy(collision.gameObject);
            }
            else
            {
                isDead = true;
                Time.timeScale = 0f;
                gameOverPanel.SetActive(true);
                isDead = false;
            }
        }
    }

}
