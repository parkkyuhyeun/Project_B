using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
	public GameObject menuSet;
	public GameObject startSet;
	public AudioSource musicsource;
	public AudioSource btnMusicsource;
	public AudioSource bounceMusicsource;

	public bool isStart = true;

    private void Awake()
    {
		Time.timeScale = 0;
		SetMusicVolume(musicsource.volume);
	}
	void Update()
	{
		if (Input.touchCount > 0 && isStart)
			GameStart();

		if (Input.GetButtonDown("Cancel"))
		{
			if (menuSet.activeSelf)
			{
				Time.timeScale = 1f;
				menuSet.SetActive(false);
			}
			else
			{
				Time.timeScale = 0f;
				menuSet.SetActive(true);
			}
		}
	}
    public void GameStart()
	{
		startSet.GetComponent<RectTransform>().DOAnchorPosY(570f, 0.65f).SetUpdate(true).OnComplete(() =>
		{
			startSet.SetActive(false);
			Time.timeScale = 1f;
			isStart = false;
		});
		
	}
	public void GameExit()
	{
		Application.Quit();
		Debug.Log("종료하기");
	}
	public void GameContinue()
    {
		Time.timeScale = 1f;
		menuSet.SetActive(false);
    }

	public void SetMusicVolume(float volume)
	{
		musicsource.volume = volume / 2f;
	}
	public void SetBtnMusicVolume(float volume)
    {
		btnMusicsource.volume = volume;
    }
	public void SetBounceMusicVolume(float volume)
    {
		bounceMusicsource.volume = volume;
    }
	public void BtnClick()
    {
		btnMusicsource.Play();
    }
}
