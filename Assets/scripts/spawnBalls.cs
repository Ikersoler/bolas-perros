using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBalls : MonoBehaviour
{
    
    

    [SerializeField] private float speed = 10f;
    


    void Update()
    {
        

        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }



}
