using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
public class Player : MonoBehaviour
{
    public Transform rockyPoint;
    public GameObject[] Rocky;
    public void Start()
    {
        InvokeRepeating("CreatRocky", 2.0f, 3.0f);
    }

    void CreatRocky()
    {
        GameObject rocky = Instantiate(Rocky[Random.Range(0, Rocky.Length)]);
        rocky.SetActive(true);
        rocky.name = "Rocky";
        
        rocky.transform.position = rockyPoint.position
            + ((Vector3)Random.insideUnitCircle * 4.0f);
        rocky.AddComponent<Rocky>();
        MeshCollider collider = rocky.AddComponent<MeshCollider>();
        collider.convex = true;
        collider.isTrigger = true;

    }

    public RigidHand hand;
    public Transform fighter;
    public float speed;
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
    }
}
