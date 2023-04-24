using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TashHelperNew : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _taskCanvas; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            _taskCanvas.SetActive(true);
        }
        else
        {
            _taskCanvas.SetActive(false);
        }
    }
}
