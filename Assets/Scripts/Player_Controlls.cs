using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MechanicalDrawing : MonoBehaviour
{
    //a private variable called body the references Rigidbody so that the code knows to im using it.
    private Rigidbody2D body;
    //a public variable float called speed that i can reference whenever i need the speed of the player character.
    public float speed = 5;
    

    private void Awake()
    {
        //a statment telling the code to get the component Rigidbody2D whenever the variable body is called.
        body = GetComponent<Rigidbody2D>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //in order to get the transform position value, use Vector2, to get it in a variable form.
        Vector2 pos = transform.position;

        //use Input,Getaxis to allow the x and y values to be modified when keys are pressed.
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;
    }
}
