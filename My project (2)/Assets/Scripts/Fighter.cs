using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fighter : MonoBehaviour
{
    public LineRenderer[] laser;
    public GameObject UI;
    bool isDeath = false;

    private void LateUpdate()
    {
        if (isDeath)
            gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        isDeath = true;
        UI.SetActive(true);
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.transform.name == "Rocky")
        {
            Rocky rocky = hit.transform.GetComponent<Rocky>();
            rocky.hp -= Time.deltaTime;
            if (rocky.hp <= 0)
            {
                Destroy(hit.transform.gameObject);
            }
            for (int i = 0; i < laser.Length; i++)
            {
                laser[i].enabled = true;
                laser[i].SetPosition(1, transform.InverseTransformPoint(rocky.transform.position));
            }
        }
        else
        {
            for (int i = 0; i < laser.Length; i++)
                laser[i].enabled = false;
        }
    }
}
