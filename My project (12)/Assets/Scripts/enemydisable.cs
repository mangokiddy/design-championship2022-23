using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydisable : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    // Start is called before the first frame update
    void Start()
    {
        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);
        enemy5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("playerCheck") == null)
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
            enemy5.SetActive(true);
        }
    }
}
