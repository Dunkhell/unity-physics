using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    private Renderer _renderer;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _renderer.material.color = generateRandomColor();
    }

    private Color generateRandomColor()
    {
        return new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
                );
    }
}
