using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int initialScore;	//��l����
    public int addScorePerSec; //�C��W�[������
    private int currScore; //�{�b������

    // Start is called before the first frame update
    void Start()
    {
        //�]�w��l����
        currScore = initialScore;
    }
    void AddScoreAndDisplay()
    {
        //�C��W�[����
        currScore += addScorePerSec;

        //���(����text����r)
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
