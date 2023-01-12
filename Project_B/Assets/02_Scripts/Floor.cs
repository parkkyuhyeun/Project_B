using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Floor : MonoBehaviour
{
    [SerializeField] public GameObject gameOverPanel;
    [SerializeField] LifeManager lifeM;
    [SerializeField] StageManager stageM;
    [SerializeField] TextMeshProUGUI stageText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obj"))
        {
            lifeM.life--;
            lifeM.UpdateLifeIcon(lifeM.life);
            if (lifeM.life != 0)
            {
                FindObjectOfType<Timer>().TimerReset();
                FindObjectOfType<Flipper>().ResetQuaternion();
                FindObjectOfType<Wingyu>().Win();
                Destroy(collision.gameObject);
            }
            else
            {
                Time.timeScale = 0f;
                stageText.text = $"{stageM.num + 1} Stage";
                gameOverPanel.SetActive(true);
            }
        }
    }

}
