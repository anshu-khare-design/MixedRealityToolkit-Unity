using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_animals : MonoBehaviour
{
    void Start()
    {
       
    }

    private void Update()
    {
        
    }

   public void move()
    {
        transform.position =  Vector3.Lerp(transform.position, transform.position + transform.forward * 2, Time.deltaTime*100);
    }
}
