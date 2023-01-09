using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] public float setTime = 10f;
    [SerializeField] public TextMeshProUGUI timeText;
    [SerializeField] public GameObject replayButton;
    void Start()
    {
        timeText.text = setTime.ToString();
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
        setTime = 10f;
        Time.timeScale = 1f;
    }
}
