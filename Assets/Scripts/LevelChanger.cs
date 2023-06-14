using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    [SerializeField] private int _level;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            if (_level == 1)
            {
                SceneManager.LoadScene("LevelTwoPreview");
            }
            if (_level == 2)
            {
                SceneManager.LoadScene("LevelInfinity");
            }
            if (_level == 3)
            {
                SceneManager.LoadScene("LevelInfinity");
                PlayerPrefs.SetInt("inf", (PlayerPrefs.GetInt("inf" + 1)));
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
