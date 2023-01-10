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
    void Start()
    {
        timeText.text = setTime.ToString();
        resultTime = setTime;
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
        else if (setTime <= 0)
        {
            timeText.text = "0.00";
        }
    }
    public void TimerReset()
    {
        replayButton.SetActive(false);
        setTime = resultTime;
        Time.timeScale = 1f;
    }
}
