using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2.5f;
    private float timer = 0f;
    public float HeightOffset = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
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
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float LowestPoint = transform.position.y - HeightOffset;
        float HighestPoint = transform.position.y + HeightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0),transform.rotation);
    }
}
