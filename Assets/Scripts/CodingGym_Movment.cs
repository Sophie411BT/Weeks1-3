using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingGymWeek3 : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed;

        Vector2 Screenpos = Camera.main.WorldToScreenPoint(pos);

        if (Screenpos.x < 0 || Screenpos.x > Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
