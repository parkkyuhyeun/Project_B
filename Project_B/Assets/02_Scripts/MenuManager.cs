using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
	public GameObject menuSet;
	public GameObject startSet;
	public AudioSource musicsource;

    private void Start()
    {
		Time.timeScale = 0;
	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
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
		});
		
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
