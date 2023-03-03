using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; 

public class Scan : MonoBehaviour
{
    public int foodCount = 0;

    private void Start()
    {
       
      
        //(on trigger)
        // make sound go off and grocery counter go up
        
    }
    //triggers sound and food counter
    private void OnTriggerEnter(Collider other)
    {
        foodCount += foodCount;
        //que sound(check gdd211 puzzle noise)
        if(foodCount == 4)
        {
            Debug.Log("Pretend the scene is changing");
        }
    }

}
