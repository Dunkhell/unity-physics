using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private Renderer renderer_trigger;

    private void Awake()
    {
        renderer_trigger = this.GetComponent<Renderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        renderer_trigger.material.color = getRandomColor();
    }

    Color getRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            0.5f
            );
    }

}
