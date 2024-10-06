using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMoveScript : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float DeadZone = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.right * MoveSpeed) * Time.deltaTime;

        if (transform.position.x > DeadZone)
        {
            Debug.Log("Projectile Died");
            Destroy(gameObject);
        }
    }
}
