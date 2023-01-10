using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingyu : MonoBehaviour
{
    [SerializeField] public GameObject[] obj;
    [SerializeField] Transform objFactory;
    public int objNum = 0;
    
    public void Win()
    {
        GameObject objs = Instantiate(obj[objNum]);
        objs.transform.position = objFactory.position;
    }
}
