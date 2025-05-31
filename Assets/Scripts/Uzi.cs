using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Uzi"))
        {
            other.transform.SetParent(transform);
            other.transform.localPosition = new Vector3(1, 0, 0);
        }
     }
}
