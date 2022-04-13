using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocky : MonoBehaviour
{
    public float hp = 0.3f;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * .05f);
        if (transform.position.z < -5)
            Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        GameObject exp = (GameObject)Instantiate(explosion, transform.position, transform.rotation);
        Destroy(exp, 2);
    }
}
