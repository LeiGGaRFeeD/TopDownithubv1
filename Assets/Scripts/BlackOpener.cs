using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOpener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            Debug.Log("Zone Opened!");
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
