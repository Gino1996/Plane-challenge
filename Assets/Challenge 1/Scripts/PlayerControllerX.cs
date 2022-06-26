using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed=50f;
    private float rotationSpeed;
    public float verticalInput,horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotationSpeed = 120f;
        // get the user's vertical input
       verticalInput = Input.GetAxis("Vertical");
       horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(0,0,5);
        // move the plane forward at a constant rate
        //transform.Translate(Vector3.back * speed);
        transform.Translate(speed*Time.deltaTime*Vector3.forward);
        //Debug.Log("Si entra en el acelerar del" +gameObject.name);
        //transform.Translate(rotationSpeed*Time.deltaTime*Vector3.right*horizontalInput);
        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        transform.Rotate(rotationSpeed*Time.deltaTime*Vector3.right*verticalInput);
        //transform.Rotate(rotationSpeed*Time.deltaTime*Vector3.up*horizontalInput);
    }
}
