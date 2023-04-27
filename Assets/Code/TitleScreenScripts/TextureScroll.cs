using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    [SerializeField] private Material scrollTexture;

    [SerializeField] private float scrollSpeedX;
    [SerializeField] private float scrollSpeedY;

    private void Start()
    {
        scrollTexture.mainTextureOffset = new Vector2(0.140f,0.140f);
    }
    void Update()
    {
        scrollTexture.mainTextureOffset += new Vector2(0.2f * scrollSpeedX * Time.deltaTime, 0.2f * scrollSpeedY * Time.deltaTime);
    }
}
