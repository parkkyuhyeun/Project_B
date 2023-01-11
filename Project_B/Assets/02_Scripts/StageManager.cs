using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI[] stagenumText;
    public int num = 0;
    private float stagenum;

    Wingyu win;
    Timer timer;
    private void Awake()
    {
        win = transform.parent.Find("ObjFactory").GetComponent<Wingyu>();
        timer = transform.parent.Find("Timer").GetComponent<Timer>();

        stagenum = num + 1;
        stagenumText[0].text = $"Stage {stagenum}\n\nClear~!";
        stagenumText[1].text = $"Stage {stagenum}";
    }
    public void Stage()
    {
        StartCoroutine(BringNextStage());
    }
    public IEnumerator BringNextStage()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
        yield return new WaitForSecondsRealtime(0.1f);
        print("break");
        win.Gacha();
        win.Win();
        panel.SetActive(false);
        timer.TimerReset();
        Time.timeScale = 1f;
        num++;
        StopCoroutine(BringNextStage());
        stagenum = num + 1;
        stagenumText[0].text = $"Stage {stagenum}\n\nClear~!";
        stagenumText[1].text = $"Stage {stagenum}";
    }
}
