using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_Lerp : MonoBehaviour
{
    //use range so that the slider apears in unity
    [Range(0, 4)]
    //float t so that the value can be controlled by the slider in unity
    public float t;
    //add an animation curve so that it can ease the lerp as the sprite moves
    public AnimationCurve curve;

    //start and end variable for the lerp values
    public Vector2 start;
    public Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        //set t equel to 0 as a starting point
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if t is greater than 4 reset to 1 so that the animation loops
        t += Time.deltaTime;
        if (t > 4)
        {
            t = 1 -1;
        }

        //set the transform position = to Lerp function so that it acually moves the sprite
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));

        
    }
}
