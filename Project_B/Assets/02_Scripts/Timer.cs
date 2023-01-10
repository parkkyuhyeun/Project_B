using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timeText;
    [SerializeField] public GameObject replayButton;
    private float setTime = 15f;
    private float resultTime;
    public bool time0 = false;

    StageManager stageM;
    private void Awake()
    {
        stageM = transform.parent.Find("StageManager").GetComponent<StageManager>();
    }
    void Start()
    {
        timeText.text = setTime.ToString();
        resultTime = setTime;
        time0 = false;
    }

    void Update()
    {
        TimerSetting();
    }

    public void TimerSetting()
    {
        if(setTime > 0)
        {
            setTime -= Time.deltaTime;
            timeText.text = $"{(Mathf.Ceil(setTime * 100.0f)) / 100.0f}";
        }
        else if (setTime <= 0 && !time0)
        {
            timeText.text = "0.00";
            stageM.Stage();
            time0 = true;
        }
    }
    public void TimerReset()
    {
        replayButton.SetActive(false);
        setTime = resultTime;
        Time.timeScale = 1f;
    }
}
