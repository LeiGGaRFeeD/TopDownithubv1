using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _finalDoc;
    [SerializeField] private Transform[] _spawnPlaces;
    private int _spawnPointNum;
    void Start()
    {
        _spawnPointNum = Random.Range(0, _spawnPlaces.Length);
        int i = 0;
        while (i != _spawnPointNum)
        {
            i++;
        }
        Instantiate(_finalDoc, _spawnPlaces[(_spawnPointNum)]);
        Debug.Log("Instatiante");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
