using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private int _speed;
    [SerializeField] private GameObject _effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.GetComponent<PlayerControl>() == false)
        //{
        
        Debug.Log("Touched!");
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        _speed = 0;
        Instantiate(_effect, gameObject.transform);

           

        gameObject.GetComponent<Collider2D>().enabled = false;
        InvokeRepeating("DestroyThis", 0.1f, 0);
        
                  // Destroy(gameObject);
        // }
    }

    void DestriyThis()
    {
        Destroy(gameObject);

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    // }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * _speed * Time.deltaTime, ForceMode2D.Impulse);
      
    }
}
