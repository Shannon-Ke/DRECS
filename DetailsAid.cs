using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsAid : MonoBehaviour
{
    public string url;
    public Image image1;
    public Image image2;

    public GameObject i1;
    public GameObject i2;
    public Button close;
    public CanvasGroup self;
    public Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        close.onClick.AddListener(Close);
        thisButton.onClick.AddListener(Load);
    }

    public void Load()
    {
        self.alpha = 1f;
        self.interactable = true;
        self.blocksRaycasts = true;
        if (url != "AidImages/brokenbones")
        {
            image1.sprite = Resources.Load<Sprite>(url);
            i2.SetActive(false);
        } else
        {
            image2.sprite = Resources.Load<Sprite>(url);
            i1.SetActive(false);
        }
    }
    void Close()
    {
        //Debug.Log("woihalsdf");
        self.alpha = 0f;
        self.interactable = false;
        self.blocksRaycasts = false;
    }
}
