using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] coctus;
    public float maxtime;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newcoctus = Instantiate(coctus[Random.Range(0, coctus.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxtime)
        {
            GameObject newcoctus = Instantiate(coctus[Random.Range(0, coctus.Length)]);
            Destroy(newcoctus, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
