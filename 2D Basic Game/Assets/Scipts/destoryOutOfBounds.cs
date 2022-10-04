using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryOutOfBounds : MonoBehaviour
{
    public float topBound;

    public float lowerBound;
  
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > topBound)
        {
            Destroy(this.gameObject);
        }
    }
}
