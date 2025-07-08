using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CahngePosition : MonoBehaviour, IHittable
{
    public Transform[] possiblePositions;

    public void OnHit()
    {
        if (possiblePositions.Length == 0) return;
        int index = Random.Range(0, possiblePositions.Length);
        transform.position = possiblePositions[index].position;
    }
}
