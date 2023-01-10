using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public int num = 0;

    Wingyu win;
    Timer timer;
    private void Awake()
    {
        win = transform.parent.Find("ObjFactory").GetComponent<Wingyu>();
        timer = transform.parent.Find("Timer").GetComponent<Timer>();
    }
    public void Stage()
    {
        StartCoroutine(BringNextStage());
    }
    public IEnumerator BringNextStage()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        print("break");
        win.objNum++;
        win.Win();
        panel.SetActive(false);
        timer.TimerReset();
        Time.timeScale = 1f;
        num++;
        StopCoroutine(BringNextStage());
    }
}
