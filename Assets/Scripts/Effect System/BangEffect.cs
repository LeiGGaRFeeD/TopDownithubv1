using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangEffect : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _effect;
    private bool _worked;
    void Start()
    {
        _worked = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            if (_worked == false)
            {
                Instantiate(_effect, gameObject.transform);
                //  Destroy(gameObject);
                _worked = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
