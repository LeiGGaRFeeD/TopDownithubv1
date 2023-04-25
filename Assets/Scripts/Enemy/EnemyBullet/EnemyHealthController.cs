using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField] private int _hp;
    public int HP => _hp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BulletScript>())
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        if (_hp > 0)
            _hp--;
    }

    private void TakeDamage(int damge)
    {
        _hp -= damge;
        if (_hp < 0)
            _hp = 0;
    }
}
