using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _bullet;
    /*public*/ int _collected;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _collected = PlayerPrefs.GetInt("gun");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_collected > 0)
            {
                Instantiate(_bullet, gameObject.transform.position, transform.rotation);
            }
        }
    }
}
