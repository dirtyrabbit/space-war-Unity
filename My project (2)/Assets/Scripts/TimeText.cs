using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    public int initialTime;	//﹍だ计
    public int addTimePerSec; //–糤だ计
    private int currTime; //瞷だ计

    // Start is called before the first frame update
    void Start()
    {
        //砞﹚﹍だ计
        currTime = initialTime;
        InvokeRepeating("AddScoreAndDisplay", 1f, 1f);
        
        //–㊣AddScoreAndDisplay()
        
    }
    void AddScoreAndDisplay()
    {
        //–糤だ计
        currTime += addTimePerSec;

        //陪ボ(跑textゅ)
        GetComponent<Text>().text = "Time: " + currTime.ToString();
    }
    public void Pause()
    {
        CancelInvoke();
    }
    public void Continue()
    {
        InvokeRepeating("AddScoreAndDisplay", 1f, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
