using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject, 0.01f);
    }
}
