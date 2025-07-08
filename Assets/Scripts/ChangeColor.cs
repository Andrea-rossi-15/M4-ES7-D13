using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IHittable
{
    public void OnHit()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
