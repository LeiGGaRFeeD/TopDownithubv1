using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    private int _health = 3;
    [SerializeField] GameObject _anim;
    void Start()
    {
        _anim.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BulletScript>())
        {
            _health = _health - 1;
        }
    }
    private void _objectState()
    {
        if (_health == 3)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(10, 10, 1);
        }
        if (_health == 2)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(8, 8, 1);
        }
        if (_health == 1)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(6, 6, 1);
        }
    }
    private void Destroing()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (_health == 0)
        {
            InvokeRepeating("Destroing", 0.5f, 0);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            _anim.SetActive(true);
        }
        _objectState();
    }
}
