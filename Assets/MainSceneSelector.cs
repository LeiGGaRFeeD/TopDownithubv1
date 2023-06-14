using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LevelOne()
    {
        SceneManager.LoadScene("LevelOnePreview");
    }
    public void LevelInf()
    {
        SceneManager.LoadScene("LevelInfinity");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
