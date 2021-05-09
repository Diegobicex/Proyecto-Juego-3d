using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    //variables públicas    
    public float ballForce = 1.0f;

    //variables privadas
    private Vector3 horizontalInput, verticalinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vamos a empujar la bola en la dirección que pulse el usuario

        //primero calculamos el input horizontal y vertical

        horizontalInput = transform.right * Input.GetAxis("Horizontal");
        verticalinput = transform.forward * Input.GetAxis("Vertical");

        //empujamos la bola con la fuerza ballforce
        GetComponent<Rigidbody>().AddForce( (horizontalInput+verticalinput) * ballForce );
    }
}
