using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    Renderer renderer_colision;

    private void Awake()
    {
        renderer_colision = this.GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        renderer_colision.material.color = getRandomColor();
    }

    Color getRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );
    }
}
