using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public int initiallevel;	//初始等級
    private int currlevel; //現在的等級

    // Start is called before the first frame update
    void Start()
    {
        //設定初始分數
        currlevel = initiallevel;
    }

    public void AddScoreAndDisplay()
    {
        //每秒增加分數
        currlevel += 1;
        //顯示(更變text的文字)
        GetComponent<Text>().text = "Level: " + currlevel.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
