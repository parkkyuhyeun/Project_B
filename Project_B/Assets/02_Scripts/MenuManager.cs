using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menuSet;
    public AudioSource musicsource;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
            }
            else
            {
                menuSet.SetActive(true);
            }
        }
    }
    public void GameExit()
    {
        Application.Quit();
        Debug.Log("�����ϱ�");
    }

    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }
}