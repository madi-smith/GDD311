using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FactMover : MonoBehaviour
{
    public void FactDown()
    {

        //GetComponent<RectTransform>().DOMove(new Vector3(4.2f, -8.2f, 0), 1f);
        // fungus positions
        GetComponent<RectTransform>().DOMoveY(0.2f, 0.3f);


    }
}
