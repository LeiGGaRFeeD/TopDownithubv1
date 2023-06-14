using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text _levels;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _levels.text = PlayerPrefs.GetFloat("inf").ToString();
    }
}
