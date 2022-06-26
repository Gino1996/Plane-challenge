using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinn : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 1000f;
        transform.Rotate(Vector3.back,speed*Time.deltaTime);

    }
}
