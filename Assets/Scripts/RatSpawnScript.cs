using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawnScript : MonoBehaviour
{

    public GameObject Rat;  
    public float SpawnRate;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnRat();
            timer = 0;
        }
    }

    void SpawnRat()
    {
        SpawnRate = Random.Range(3.0f, 10.0f);

        Instantiate(Rat, new Vector3(transform.position.x,transform.position.y, 0), transform.rotation);
    }
}
