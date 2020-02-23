using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapIconController : MonoBehaviour
{
    public GameObject image;
    public Button butt;

    private void Start()
    {
        butt.onClick.AddListener(Toggle);
    }

    public void Toggle()
    {
        //Debug.Log("helloo");
        if (!image.activeSelf)
        {
            //Debug.Log("helloo");
            image.SetActive(true);
        }
    }

    public void Clear()
    {
        image.SetActive(false);
    }

}
