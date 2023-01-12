using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lifeText;
    public int life = 3;
    void Start()
    {
        lifeText.text = $"Life : {life}";
    }
    public void SetLife()
    {
        lifeText.text = $"Life : {life}";
    }
}
