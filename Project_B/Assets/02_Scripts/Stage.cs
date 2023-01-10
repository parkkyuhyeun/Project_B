using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    void Start() //�����ϸ� �ҷ���
    {
        DataManager.Instance.LoadGameData();
    }

    private void OnApplicationQuit() //�����ϸ� ����
    {
        DataManager.Instance.SaveGameData();
    }

    public void StageClear(int stageNum)
    {
        DataManager.Instance.data.isClear[stageNum] = true;
        DataManager.Instance.SaveGameData(); //����
    }
}
