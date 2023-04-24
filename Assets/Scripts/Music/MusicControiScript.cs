using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControiScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int _musicState;
    [SerializeField] GameObject _IDLE;
    [SerializeField] GameObject _StartLevel;
  //  [SerializeField] GameObject _Angry;
   // [SerializeField] GameObject _Max;
    void Start()
    {
        _musicState = 1;   
    }

    // Update is called once per frame
    void MusicControl()
    {
        if (_musicState == 1) 
        {
            _IDLE.GetComponent<AudioSource>().volume = 100;
            _StartLevel.GetComponent<AudioSource>().volume = 0;
       //     _Angry.GetComponent<AudioSource>().volume = 0;
        //    _Max.GetComponent<AudioSource>().volume = 0;
        }
        if (_musicState == 2)
        {
            _IDLE.GetComponent<AudioSource>().volume = 0;
            _StartLevel.GetComponent<AudioSource>().volume = 100;
       //     _Angry.GetComponent<AudioSource>().volume = 0;
        //    _Max.GetComponent<AudioSource>().volume = 0;
        }
        if (_musicState == 3)
        {
            _IDLE.GetComponent<AudioSource>().volume = 0;
            _StartLevel.GetComponent<AudioSource>().volume = 0;
      //      _Angry.GetComponent<AudioSource>().volume = 100;
       //     _Max.GetComponent<AudioSource>().volume = 0;
        }
        if (_musicState == 4)
        {
            _IDLE.GetComponent<AudioSource>().volume = 0;
            _StartLevel.GetComponent<AudioSource>().volume = 0;
      //      _Angry.GetComponent<AudioSource>().volume = 0;
        //    _Max.GetComponent<AudioSource>().volume = 100;
        }
        if (_musicState == 0)
        {
            _IDLE.GetComponent<AudioSource>().volume = 0;
            _StartLevel.GetComponent<AudioSource>().volume = 0;
          //  _Angry.GetComponent<AudioSource>().volume = 0;
           // _Max.GetComponent<AudioSource>().volume = 0;
        }
    }
    void Update()
    {
        MusicControl();
        Debug.Log("Music state = "+_musicState);
    }
}
