using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI timeText;
    private float setTime = 0.1f;
    private float resultTime;
    public bool time0 = false;

    StageManager stageM;
    private void Awake()
    {
        stageM = transform.parent.Find("StageManager").GetComponent<StageManager>();
        
    }
    void Start()
    {
        timeText.text = setTime.ToString("F2");
        resultTime = setTime;
        time0 = false;
    }

    void Update()
    {
        TimerSetting();

        if (Input.GetKeyDown(KeyCode.F))
        {
            setTime = 0;
        }
    }

    public void TimerSetting()
    {
        if(setTime > 0)
        {
            setTime -= Time.deltaTime;
            timeText.text = (Mathf.Ceil(setTime * 100.0f) / 100.0f).ToString("F2");
        }
        else if (setTime <= 0 && !time0)
        {
            timeText.text = "0.00";
            stageM.Stage();
            FadeEffect.Instance.LoadingScene();
            Destroy(FindObjectOfType<Obj>().transform.gameObject);
            time0 = true;
        }
    }
    public void TimerReset()
    {
        setTime = resultTime;
        Time.timeScale = 1f;
        time0 = false;
    }
}
