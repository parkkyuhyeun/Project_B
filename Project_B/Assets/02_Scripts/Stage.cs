using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    void Start() //시작하면 불러옴
    {
        DataManager.Instance.LoadGameData();
    }

    private void OnApplicationQuit() //종료하면 저장
    {
        DataManager.Instance.SaveGameData();
    }

    public void StageClear(int stageNum)
    {
        DataManager.Instance.data.isClear[stageNum] = true;
        DataManager.Instance.SaveGameData(); //저장
    }
}
