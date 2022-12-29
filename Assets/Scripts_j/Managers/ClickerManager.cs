using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerManager : MonoBehaviour
{
    // �ѹ� Ŭ���� ȹ���� ��ȭ
    public int clickMineralAmount = 5;

    public bool enableClick = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && enableClick)
        {
            StatManager.Instance.AddMineral(clickMineralAmount);
        }
    }
}
