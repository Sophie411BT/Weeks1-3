using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars_AnimationCurve : MonoBehaviour
{
    //add animation curve so that it shows up in unity window
    public AnimationCurve curve;
    //add range so the movment can be controlled with slider
    [Range(0, 1)]
    //declare float t so the values can be controlled
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        //set t = to 0 as a starting point
        t = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        //if t is greater than 1 reset it to 0
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        //set transform.localscale to the curve so that the animation curve can controll the scale values
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
