using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardLevelOne : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _dialogIcon;
    [SerializeField] private GameObject _cloud;
    [SerializeField] private GameObject text;
    void Start()
    {
        _cloud.SetActive(false);
        text.SetActive(false);
        _dialogIcon.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
       //     _dialogIcon.SetActive(true);
            // if (Input.GetKeyDown(KeyCode.E))
            // {
            _cloud.SetActive(true);
            text.SetActive(true);
            // Debug.Log("E button pressed!");
            //}
            //else 
            {
                //_cloud.SetActive(false);
                // text.SetActive(false);
            }
            Debug.Log("in trigger");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            _cloud.SetActive(false);
            text.SetActive(false);
            _dialogIcon.SetActive(false);
        }
      //  Debug.Log("out off trigger");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
