using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
        if (TF == 0)
        {
            GetComponent<RectTransform>().DOMove(new Vector3(5.16f, -1.8f, 0), 1f);
            TF = 1;
        }
    }
    public void TogglePhoneDown()
    {
        if (TF == 1)
        {
            GetComponent<RectTransform>().DOMove(new Vector3(5f, -6.6f, 0), 1f);
            TF = 0;
        }
    }
   
}
