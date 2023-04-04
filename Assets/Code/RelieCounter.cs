using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RelieCounter : MonoBehaviour
{
    public int count = 0;
    public int total;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reliable")
        {
            count = count + 1;

        }
        if (count == total)
        {
            SceneManager.LoadScene(1);
        }
    }
}
