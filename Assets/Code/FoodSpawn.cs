using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //spawns food to the scanned, moves it down to converybelt
    public GameObject[] FoodArray;
    public GameObject FoodItem;
    private float Timer = 1;

    private void Start()
    {
        Timer = 1;
    }
    private void Update()
    {
        Timer -= 1 * Time.deltaTime;
        //FoodItem

        if (Timer <= 0)
        {
            Instantiate(FoodItem, new Vector3(0.2f, -2.7f, 0f), Quaternion.identity);

            Timer = 2;
        }
  
    }
}
