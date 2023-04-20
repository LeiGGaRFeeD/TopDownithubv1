using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    private int _money;
    [SerializeField] private GameObject _effectCollect;
    private bool _isCollected;
    void Start()
    {
        _effectCollect.SetActive(false);
        _isCollected = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            if (_isCollected == false)
            {
                PlayerPrefs.SetInt("money", _money + 1000);
                _effectCollect?.SetActive(true);
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                _isCollected = true;
                InvokeRepeating("DestroyObj", 1, 0);
            }
        }
    }
    void DestroyObj()
    {
        Destroy(gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        _money = PlayerPrefs.GetInt("money");
    }
}
