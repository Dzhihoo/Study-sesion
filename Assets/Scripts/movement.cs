using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // DetectImput();
        ProccessJump();
        ProccessRotate(1);
        ProccessDrive(20);
    }
    void DetectImput()
    {
        float velocity = 10f;
        float XMovement = Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
        float ZMovement = Input.GetAxis("Vertical") * velocity * Time.deltaTime;
       

        transform.Translate(XMovement, 0, ZMovement );
        //transform.position= new Vector3(transform.position.x + XlMovement,transform.position.y + ZMovement) * velocity * Time.deltaTime;
        Debug.Log(XMovement);
        Debug.Log(ZMovement);

     

    }
    void ProccessRotate(float value)
    { 

        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, value/4, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -value/4, 0);
        }
       
                
    }
    void ProccessDrive(float value)
    {
        
        value *= Time.deltaTime;
        if (Input.GetKey(KeyCode.W))

        {
            transform.Translate(0, 0, value);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -value);
        }
    }

    void ProccessJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * 500f);

        }

    }

}

