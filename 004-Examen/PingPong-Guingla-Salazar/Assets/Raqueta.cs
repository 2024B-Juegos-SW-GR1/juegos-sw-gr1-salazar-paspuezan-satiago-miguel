using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool esRaquetaLeft;
    private float yBound = 3.75f;
    
    void Update()
    {
        float movement;
        if (esRaquetaLeft)
        {
            movement =  Input.GetAxisRaw("Vertical");
        }else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        Vector2 raquetaPosicion = transform.position;
        raquetaPosicion.y = Mathf.Clamp(raquetaPosicion.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = raquetaPosicion;
    }
}
