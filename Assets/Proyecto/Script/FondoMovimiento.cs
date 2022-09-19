using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FondoMovimiento : MonoBehaviour
{
    [SerializeField]
    RawImage scrollableImage;
    [SerializeField]
    float scrollSpeed;
    Rect rect;
    void Start()
    {
        rect = scrollableImage.uvRect;
    }

    void Update()
    {
        rect.x += scrollSpeed*Time.deltaTime;
        scrollableImage.uvRect = rect;
    }

}
