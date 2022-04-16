using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public int initiallevel;	//﹍单
    private int currlevel; //瞷单

    // Start is called before the first frame update
    void Start()
    {
        //砞﹚﹍だ计
        currlevel = initiallevel;
    }

    public void AddScoreAndDisplay()
    {
        //–糤だ计
        currlevel += 1;
        //陪ボ(跑textゅ)
        GetComponent<Text>().text = "Level: " + currlevel.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
