using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurve : MonoBehaviour 
{

    public AnimationCurve curve;

    public float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        transform.localScale = Vector2.one * curve.Evaluate(1);
    }

    private Vector2 Evaluate(int v)
    {
        throw new NotImplementedException();
    }
}
