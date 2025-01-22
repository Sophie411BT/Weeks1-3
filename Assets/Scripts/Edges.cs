using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edges : MonoBehaviour
    
{
    //create a private vector2 called bound to refer to the screen boundries
    private Vector2 bound;
    //craete variables for the width and height of the object
    private float Width = 10;
    private float Height = 4;
    // Start is called before the first frame update
    void Start()
    {

        //use x and y to find screen boundries in world sace. this way the code knows wher the boundries will be
        bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Width = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        Height = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //create new vector3 and set it to transform position
        Vector3 viewPos = transform.position;
        //check to see if the player is at the edge of the screen
        viewPos.x = Mathf.Clamp(viewPos.x, bound.x * -1 - Width, bound.x + Width);
        viewPos.y = Mathf.Clamp(viewPos.y, bound.y * -1 - Height, bound.y + Height);
        //set the players position to the new position
        transform.position = viewPos;

        {

        }
    }
}
