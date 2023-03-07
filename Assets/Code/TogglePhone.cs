using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TogglePhone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void TogglePhonePress()
    {
        GetComponent<RectTransform>().DOMove(new Vector3(5.16f, -1.8f, 0), 1f);
    }
   /* public void TogglePhoneDown()
    {
        GetComponent<RectTransform>().DOMove(new Vector3(5f, -6.6f, 0), 1f);
    }
   */
}
