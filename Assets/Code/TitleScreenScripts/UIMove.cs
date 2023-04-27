using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMove : MonoBehaviour
{
    [SerializeField] private Image titleTop;
    [SerializeField] private Image titleBottom;

    [SerializeField] private Image endMoveTop;
    [SerializeField] private Image endMoveBottom;

    void Start()
    {
        titleTop.transform.DOMove((endMoveTop.transform.position), 2.5f);
        titleBottom.transform.DOMove((endMoveBottom.transform.position), 2.5f);
    }

    
    void Update()
    {
     
    }
}
