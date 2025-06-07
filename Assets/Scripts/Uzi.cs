using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.parent != null)
        {
            float parentScaleX = transform.parent.localScale.x;

            // Flip по направлению родителя
            spriteRenderer.flipX = parentScaleX < 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Uzi"))
        {
            other.transform.SetParent(transform);
            other.transform.localPosition = new Vector3(1, 0, 0);
        }
    }
}
