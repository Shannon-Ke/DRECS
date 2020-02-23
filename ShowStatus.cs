using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStatus : MonoBehaviour
{
    public CanvasGroup status;
    public Button open;
    // Start is called before the first frame update
    void Start()
    {
        open.onClick.AddListener(Open);
    }

    void Open()
    {
        //Debug.Log("wtf");
        status.alpha = 1f;
        status.interactable = true;
        status.blocksRaycasts = true;
    }
}
