using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public int initiallevel;	//��l����
    private int currlevel; //�{�b������

    // Start is called before the first frame update
    void Start()
    {
        //�]�w��l����
        currlevel = initiallevel;
    }

    public void AddScoreAndDisplay()
    {
        //�C��W�[����
        currlevel += 1;
        //���(����text����r)
        GetComponent<Text>().text = "Level: " + currlevel.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
