using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    private int _health = 3;
    private bool _isPlus = false;
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
            _objectState();
        }
    }
    private void _objectState()
    {
        if (_health == 3)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(10, 10, 1);
            //PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + 100));
        }
        if (_health == 2)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(8, 8, 1);
           PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + 100));
         //   InvokeRepeating("MoneyGetter", 0.1f, 0.5f);
        }
        if (_health == 1)
        {
            gameObject.GetComponent<Transform>().localScale = new Vector3(6, 6, 1);
            PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + 250));
        }
    }
    private void MoneyGetter()
    {
        int money = 100;
        PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + money));
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
            gameObject.GetComponent<Collider2D>().enabled = false;  
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            _anim.SetActive(true);
            if (_isPlus == false)
            {
                PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + 500));
                _isPlus = true;
            }
        }

        //_objectState();
    }
}
//реалиховать плавное появление денег