using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMaps : MonoBehaviour
{
    public string url;
    public Button butt;
    //public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        butt.onClick.AddListener(OpenURL);
    }

    void OpenURL()
    {
        Debug.Log("going to URL");
        Application.OpenURL(url);
        //parent.SetActive(false);
    }
}
