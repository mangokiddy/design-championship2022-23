using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    private Image health;
    private float current;
    private float max = 5f;
    MovementPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Image>();
        player = FindObjectOfType<MovementPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        current = player.currenthealth;
        health.fillAmount = current/max;
    }
}
