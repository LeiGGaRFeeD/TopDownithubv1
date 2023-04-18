using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GoToLevelTwo()
    {
        Debug.Log("Go to level 2");
        SceneManager.LoadScene("LevelTwo");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
