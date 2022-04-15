using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Button
using UnityEngine.SceneManagement; //SceneManager
public class StartMenu : MonoBehaviour
{
    public int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            ClickEvent();
        });
    }
    void ClickEvent()
    {
        //¤Á´«Scene
        SceneManager.LoadScene(sceneIndex);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
