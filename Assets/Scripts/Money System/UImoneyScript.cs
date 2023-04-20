using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImoneyScript : MonoBehaviour
{
    [SerializeField] private Text _moneyText;
    private int _money;

    // Start is called before the first frame update
    void Start()
    {
      _money =  PlayerPrefs.GetInt("money");
    }
    
    // Update is called once per frame
    void Update()
    {
        _money = PlayerPrefs.GetInt("money");
        _moneyText.text = _money.ToString();
    }
}
