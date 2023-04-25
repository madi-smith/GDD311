using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnrelieCounter : MonoBehaviour
{
    public int count = 0;
    public int total;

    //triggers sound and food counter
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Unreliable")
        {
            count = count + 1;

        }
        if (count == total)
        {
            //SceneManager.LoadScene(1);
        }
    }
}
