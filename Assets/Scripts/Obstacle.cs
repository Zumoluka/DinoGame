using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f;  // La misma velocidad del suelo

    void Update()
    {
        // Mueve el obstáculo hacia la izquierda
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Desactiva el obstáculo si sale de la pantalla
        if (transform.position.x < -10f)
        {
            gameObject.SetActive(false); // En lugar de destruir, se desactiva para reutilizar
        }
    }
}
