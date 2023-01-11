using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingyu : MonoBehaviour
{
    [SerializeField] public GameObject[] obj;
    [SerializeField] Transform objFactory;
    public List<int> GachaList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    public List<int> ImshyList = new List<int>();
    public int objNum;
    public bool setting = true;

    private void Start()
    {
        if (setting)
        {
            ImshyList = GachaList;
            setting = false;
        }
    }
    private void Update()
    {
        ResetList();
    }
    public void Gacha()
    {
        int rand = Random.Range(0, GachaList.Count);
        print(GachaList[rand]);
        objNum = rand;
        GachaList.RemoveAt(rand);
    }
    public void Win()
    {
        GameObject objs = Instantiate(obj[objNum]);
        objs.transform.position = objFactory.position;
    }
    public void ResetList()
    {
        if(GachaList.Count == 0)
        {
            GachaList = ImshyList;
            setting = true;
        }
    }
}
