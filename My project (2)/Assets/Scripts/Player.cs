using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using System.Threading;

public class Player : MonoBehaviour
{
    public Transform rockyPoint;
    public GameObject[] Rocky;
    public GameObject leveltext;
    public float CreatRockyspeed;
    public float repeatRate;
    public void Start()
    {
        leveltext.SetActive(true);
        leveltext.GetComponent<LevelText>().AddScoreAndDisplay();
        InvokeRepeating("CreatRocky", CreatRockyspeed , repeatRate);
        
    }

    void CreatRocky()
    {
        GameObject rocky = Instantiate(Rocky[Random.Range(0, Rocky.Length)]);
        rocky.SetActive(true);
        rocky.name = "Rocky";
        
        rocky.transform.position = rockyPoint.position
            + ((Vector3)Random.insideUnitCircle * 8.0f);
        rocky.AddComponent<Rocky>();
        MeshCollider collider = rocky.AddComponent<MeshCollider>();
        collider.convex = true;
        collider.isTrigger = true;

    }
    public RigidHand hand;
    public Transform fighter;
    public int currLevel = 1;
    public int addLevelRule;
    public float accelerateRockyspeed;
    public int speed;
    // Update is called once per frame
    void Update()
    {

        if (hand.gameObject.activeSelf)
        {
            fighter.gameObject.SetActive(true);
            Vector3 position = new Vector3(hand.GetPalmPosition().x * speed,
                hand.GetPalmPosition().y * speed, fighter.position.z);
            fighter.position = position;

        }
        else
        {
            fighter.gameObject.SetActive(false);
        }
        if (GameObject.Find("Score").GetComponent<ScoreText>().getScore() > currLevel * addLevelRule)
        {
            if(accelerateRockyspeed < CreatRockyspeed)
            {
                InvokeRepeating("CreatRocky", CreatRockyspeed, repeatRate);
                leveltext.GetComponent<LevelText>().AddScoreAndDisplay();
                currLevel++;
            }
        }
    }
}
