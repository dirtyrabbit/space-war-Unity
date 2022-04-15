using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int initialScore;	//﹍だ计
    public int addScorePerSec; //–糤だ计
    private int currScore; //瞷だ计

    // Start is called before the first frame update
    void Start()
    {
        //砞﹚﹍だ计
        currScore = initialScore;
    }
    void AddScoreAndDisplay()
    {
        //–糤だ计
        currScore += addScorePerSec;

        //陪ボ(跑textゅ)
        GetComponent<Text>().text = "Score: " + currScore.ToString();
    }

    public void DestoryRocky()
    {
        AddScoreAndDisplay();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
