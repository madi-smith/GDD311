using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class TogglePhone : MonoBehaviour
{
    public int TF;
    void Start()
    {
        TF = 0;
    }

    // Update is called once per frame
    public void TogglePhonePress()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.21f, -0.9f, 0), 1f);

        // fungus positions
        GetComponent<RectTransform>().DOMoveY(0f, 1f);
    
    }
    public void TogglePhoneDown()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.2f, -8.2f, 0), 1f);
        // fungus positions
        GetComponent<RectTransform>().DOMoveY(-8f, 1f);
        //Vector3(4.71000004,-8.30000019,0)


    }

}
