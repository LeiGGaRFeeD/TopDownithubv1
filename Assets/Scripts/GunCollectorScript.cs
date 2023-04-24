using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCollectorScript : MonoBehaviour
{
   // [SerializeField] private FirePlayer _firePlayer; //Создаем переменную с типом данных скрипта
    [SerializeField] private GameObject _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            PlayerPrefs.SetInt("gun", 1);
            _anim.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
            InvokeRepeating("Destroing", 1, 0);
          //  _firePlayer._collected = 1; //изменяем значение в другом. Важно, что переменная должна быть Public
        }
    }
    private void Destroing()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
