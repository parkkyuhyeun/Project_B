using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
	public GameObject menuSet;
	public GameObject startSet;
	public AudioSource musicsource;
	public float time = 0;
	void Update()
	{
		time = Time.deltaTime;
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
			GameStart();
		}
	}
	public void GameStart()
	{
		startSet.GetComponent<RectTransform>().DOAnchorPosY(570f, 0.65f);
	}
	public void GameExit()
	{
		Application.Quit();
		Debug.Log("종료하기");
	}

	public void SetMusicVolume(float volume)
	{
		musicsource.volume = volume;
	}
}
