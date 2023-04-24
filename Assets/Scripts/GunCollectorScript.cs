using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCollectorScript : MonoBehaviour
{
    [SerializeField] private FirePlayer _firePlayer; //Создаем переменную с типом данных скрипта
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>())
        {
            PlayerPrefs.SetInt("gun", 1);
            Destroy(gameObject);
          //  _firePlayer._collected = 1; //изменяем значение в другом. Важно, что переменная должна быть Public
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
