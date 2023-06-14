using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpener : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _invisibleWall;
    void Start()
    {
        _invisibleWall.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControl>())
        {
            _invisibleWall.SetActive(false);
            Destroy(gameObject);
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
