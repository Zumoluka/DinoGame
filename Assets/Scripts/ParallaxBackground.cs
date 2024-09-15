using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public float parallaxSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.left * parallaxSpeed * Time.deltaTime);

        if (transform.position.x < -20f)
        {
            Vector2 newPosition = new Vector2(10f, transform.position.y);
            transform.position = newPosition;
        }
    }

}
