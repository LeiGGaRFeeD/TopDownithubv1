using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    private int _money;
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            PlayerPrefs.SetInt("money", _money + 1000);
        }
    }
    // Update is called once per frame
    void Update()
    {
        _money = PlayerPrefs.GetInt("money");
    }
}
