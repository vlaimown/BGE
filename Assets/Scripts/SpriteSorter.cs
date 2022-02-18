using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    public float offset = 0;
    private int sortingOrderBase = 0;
    private Renderer myrenderer;

    private void Awake()
    {
        myrenderer = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        myrenderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);
    }
}
