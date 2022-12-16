using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
       var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
       transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
