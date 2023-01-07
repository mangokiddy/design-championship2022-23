using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Power Source")
        {
            GameObject.Find("Power Source").GetComponent<PowerSource>().currentPower -= 1f;
        }

        Destroy(gameObject, 0.03f);
    }
}
