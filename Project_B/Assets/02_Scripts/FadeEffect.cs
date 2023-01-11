using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class FadeEffect : MonoBehaviour
{
    public static FadeEffect Instance;

    public Image loadingImage;
    public TextMeshProUGUI txt;
    private void Awake()
    {
        Instance = this;
    }

    public void LoadingScene()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        loadingImage.DOFade(1, .2f);
        yield return new WaitForSecondsRealtime(1.5f);
        loadingImage.DOFade(0, .2f);
        txt.text = "";
    }
}
