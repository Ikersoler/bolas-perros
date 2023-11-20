using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnperros : MonoBehaviour
{
    [SerializeField] private GameObject Dogprefab;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFood();
        }
    }

    private void ShootFood()
    {
        Instantiate(Dogprefab, transform.position, Quaternion.Euler(x: 0, y: -90, z: 0));
        
    }




}







