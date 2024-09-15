using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -20f) // Reposicionar el suelo
        {
            Vector2 newPosition = new Vector2(40f, transform.position.y);
            transform.position = newPosition;
        }
    }
}
