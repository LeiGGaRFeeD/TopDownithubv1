using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   // [SerializeField] private BlowEffect _blowEffect;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    [SerializeField] private float _destroyTime;

    public void Start()
    {
        Invoke("DestroyBullet", _destroyTime);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(transform.right * _speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyBullet();
        ShowEffect();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControl>())
        {
            Debug.Log("Player contact!");
        }
        if (collision.gameObject.GetComponent<PlayerControl>() == false)
        {
            Destroy(collision.gameObject);
         //   Debug.Log("Player contact!");
        }
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void ShowEffect()
    {
     //   Instantiate(_blowEffect, transform.position, transform.rotation);
    }
}
