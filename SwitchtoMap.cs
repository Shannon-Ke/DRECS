using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchtoMap : MonoBehaviour
{
    public Button butt;
    // Start is called before the first frame update
    void Start()
    {
        butt.onClick.AddListener(OpenMap);
    }

    void OpenMap()
    {
        SceneManager.LoadScene("Map");
    }
}
