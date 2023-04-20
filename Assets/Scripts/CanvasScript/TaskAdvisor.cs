using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskAdvisor : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] GameObject _rightScreenPart;
    [SerializeField]float _velocity = 200;
    [SerializeField] float _speed = 10;
    private bool _playing = false;

    [SerializeField] private RectTransform _transform;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            //  _transform.position = Vector2.MoveTowards(_transform.position,new Vector2(Screen.width,_transform.position.y), Time.deltaTime * _velocity);
            _playing = true;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //  _transform.position = Vector2.MoveTowards(_transform.position,new Vector2(Screen.width,_transform.position.y), Time.deltaTime * _velocity);
            _playing = false;
        }
        if (_playing == true)
        {
            _transform.position = Vector2.MoveTowards(_transform.position, new Vector2((Screen.width*2), _transform.position.y), Time.deltaTime * _velocity);
        }

    }
}
