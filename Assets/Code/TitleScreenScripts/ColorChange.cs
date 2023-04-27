using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Image overlapBlue;
    [SerializeField] private Image overlapOrange;
    

    [SerializeField] private Color colorOverlapB;
    [SerializeField] private Color colorOverlapO;
    

    [SerializeField] private float colorChangeSpeed;
    [SerializeField] private float reference;

    [SerializeField] private bool onTitle;
    [SerializeField] private bool switchColor;
    void Start()
    {
        onTitle = false;
    }

    // eldritch horror loop
    void Update()
    {
        overlapBlue.color = colorOverlapB;
        overlapOrange.color = colorOverlapO;
       
        reference = colorOverlapB.a;

        if (colorOverlapB.a <= 0f)
        {
            switchColor = true;
        }

        if(colorOverlapB.a >= 0.65f)
        {
            switchColor = false;
        }

        if(switchColor == true)
        {
            colorOverlapB.a += colorChangeSpeed * Time.deltaTime;
            colorOverlapO.a += -colorChangeSpeed * Time.deltaTime;
        }

        if (switchColor == false)
        {
            colorOverlapB.a += -colorChangeSpeed * Time.deltaTime;
            colorOverlapO.a += colorChangeSpeed * Time.deltaTime;
        }

        if(colorOverlapO.a <= 0f)
        {
            colorOverlapO.a = 0f;
        }

    }

}

