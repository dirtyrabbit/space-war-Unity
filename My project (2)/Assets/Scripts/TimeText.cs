using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    public int initialTime;	//��l����
    public int addTimePerSec; //�C��W�[������
    private int currTime; //�{�b������

    // Start is called before the first frame update
    void Start()
    {
        //�]�w��l����
        currTime = initialTime;
        InvokeRepeating("AddScoreAndDisplay", 1f, 1f);
        
        //�C��I�sAddScoreAndDisplay()
        
    }
    void AddScoreAndDisplay()
    {
        //�C��W�[����
        currTime += addTimePerSec;

        //���(����text����r)
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
