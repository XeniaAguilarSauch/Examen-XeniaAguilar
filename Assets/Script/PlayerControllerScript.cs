using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//per a fer ús de les escenes
using UnityEngine.SceneManagement;

public class PlayerControllerScript : MonoBehaviour
{
    public string sisisis;
    public float speed;
    public float rotationSpeed;
     
    private Rigidbody rb;

   

    public float impulse;

    
   
    //rotation speed;(apunts)
    // Start is called before the first frame update
    void Start()
    //--------------------------Inici Start ---------------------------------
    {
       Debug.Log("Hola " + sisisis);

       rb = GetComponent<Rigidbody>();

    //--------------------------Final Start ---------------------------------
    }

    // Update is called once per frame
    void Update()
    {
        //--------------------------Inici Update ---------------------------------
        //moviment del objecte/player
       transform.Translate(0,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);
       //transform.Translate(Input.GetAxis("Vertical") * speed * Time.deltaTime,0,0);
       transform.Rotate(0,Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime,0);
       /*
       */
      

    

       //Ús de tecles per saltar

       if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f) 
       {
        rb.velocity = new Vector3 (0, impulse, 0);

       }


       
       //--------------------------Final Update ---------------------------------
    }


    
    
}
