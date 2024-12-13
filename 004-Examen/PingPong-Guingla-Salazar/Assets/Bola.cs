using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Bola : MonoBehaviour
{
    [SerializeField] private float vo = 4f;
    private Rigidbody2D bolaRb;
    [SerializeField] private float velocityMultiplier = 1.1f;
    
    void Start()
    {
        bolaRb = GetComponent<Rigidbody2D>();
        Launch();

    }

    private void Launch()
    {
        float velocidadX = Random.Range(0, 2)==0 ? -1 : 1;
        float velocidadY = Random.Range(0, 2) == 0 ? -1 : 1;
        bolaRb.velocity = new Vector2(velocidadX, velocidadY)*vo;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Raqueta"))
        {
            bolaRb.velocity *= velocityMultiplier;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal1"))
        {
            GameManager.Instance.Raqueta2Score();
            GameManager.Instance.Restart();
            Launch();
        }
        else
        {
            GameManager.Instance.Raqueta1Score();
            GameManager.Instance.Restart();
            Launch();
        }
    }
}
