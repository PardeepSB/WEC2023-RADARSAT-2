using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcaMovement : MonoBehaviour
{

    public GameObject target;
    public float speed = 10;
    public Vector3 direction = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime);
    }
}
