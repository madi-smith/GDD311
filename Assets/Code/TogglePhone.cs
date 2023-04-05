using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class TogglePhone : MonoBehaviour
{
    public int TF;
    public int PhoneChecker = 0;
    void Start()
    {
        TF = 0;
    }

    // Update is called once per frame
    public void TogglePhonePress()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.21f, -0.9f, 0), 1f);

        // fungus positions
        GetComponent<RectTransform>().DOMoveY(7.6f, 1f);

        PhoneChecker = PhoneChecker + 1;
        if(PhoneChecker == 4)
        {
            SceneManager.LoadScene(1);
        }
    
    }
    public void TogglePhoneDown()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.2f, -8.2f, 0), 1f);
        // fungus positions
        GetComponent<RectTransform>().DOMoveY(0f, 1f);


    }
   
}
