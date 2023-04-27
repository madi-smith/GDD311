using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void BackToGameButton()
    {
        SceneManager.LoadScene(0);
    }
    public void GroceryButton()
    {
        SceneManager.LoadScene(2);
    }
    public void ClassButton()
    {
        SceneManager.LoadScene(1);
    }
    public void BedroomButton()
    {
        SceneManager.LoadScene(3);
    }
}
