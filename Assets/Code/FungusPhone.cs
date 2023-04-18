using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FungusPhone : MonoBehaviour
{
    // Update is called once per frame
    public void TogglePhonePress()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.21f, -0.9f, 0), 1f);

        // fungus positions
        GetComponent<RectTransform>().DOMoveY(7.9f, 1f);

    }
    public void TogglePhoneDown()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.2f, -8.2f, 0), 1f);
        // fungus positions
        GetComponent<RectTransform>().DOMoveY(0.6f, 1f);



    }
}
