using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
     private float leftBound = -30f;
     private float bottomBound = -0f;

    private void Update()
    {
        
        //proyectiles
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }


        //bolas

        if (transform.position.y < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log(message: "GAME OVER");
            Time.timeScale = 0f;
        }
        
    }
}
