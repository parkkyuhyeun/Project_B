using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingPanel : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(FindObjectOfType<Obj>().transform.gameObject);
    }
}
