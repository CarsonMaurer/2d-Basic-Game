using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFoward : MonoBehaviour
{
    public float moveSpeed = 5;



  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
