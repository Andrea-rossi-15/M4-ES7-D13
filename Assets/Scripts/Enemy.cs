using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHittable
{
    public int hitPoints = 3;
    private int currentHits = 0;

    public void OnHit()
    {
        currentHits++;
        if (currentHits >= hitPoints)
        {
            Destroy(gameObject);
        }
    }

}
