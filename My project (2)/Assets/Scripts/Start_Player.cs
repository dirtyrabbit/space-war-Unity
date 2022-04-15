using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Player : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
