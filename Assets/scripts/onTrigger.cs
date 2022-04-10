using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger : MonoBehaviour
{
    private Renderer _renderer;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnTriggerExit(Collider other)
    {
        _renderer.material.color = generateRandomColor();
    }

    private Color generateRandomColor()
    {
        return new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                0.5f
                );
    }
}
