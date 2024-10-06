using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawnScript : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //Will launch projectile prefab
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
