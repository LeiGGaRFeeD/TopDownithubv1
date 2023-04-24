using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private int _dialogState;
    [SerializeField] private Text _text;
    private string _dialogTextSTR = " ";
    void Start()
    {
        _dialogState = PlayerPrefs.GetInt("dialogGuard");
        if (_dialogState == null)
        {
            _dialogState = 1;
        }
    }
    private void _dialogs()
    {
        if (_dialogState == 1)
        {
            _dialogTextSTR = "Welcome to EverTree Company Office!";
            _text.text = _dialogTextSTR.ToString();
        }
        if (_dialogState == 2)
        {
            _dialogTextSTR = "HELP!!!";
            _text.text = _dialogTextSTR.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
