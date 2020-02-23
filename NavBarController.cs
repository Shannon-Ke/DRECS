using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavBarController : MonoBehaviour
{
    public GameObject H;
    public GameObject C;
    public GameObject M;
    public GameObject A;

     Button home;
     Button chat;
     Button map;
     Button aid;

    //SpriteRenderer homeImage;
    //SpriteRenderer chatImage;
    //SpriteRenderer mapImage;
    //SpriteRenderer aidImage;
    // Start is called before the first frame update
    void Start()
    {
        home = H.GetComponent<Button>();
        chat = C.GetComponent<Button>();
        map = M.GetComponent<Button>();
        aid = A.GetComponent<Button>();

        //homeImage = H.GetComponent<SpriteRenderer>();
        //chatImage = C.GetComponent<SpriteRenderer>();
        //mapImage = M.GetComponent<SpriteRenderer>();
        //aidImage = A.GetComponent<SpriteRenderer>();

        home.onClick.AddListener(delegate { ShiftScene("Home"); });
        chat.onClick.AddListener(delegate { ShiftScene("Chat"); });
        map.onClick.AddListener(delegate { ShiftScene("Map"); });
        aid.onClick.AddListener(delegate { ShiftScene("Aid"); });
        
    }

    public void ShiftScene(string name)
    {
        //homeImage.sprite = Resources.Load<Sprite>("Icons/home_unclicked");
        //chatImage.sprite = Resources.Load<Sprite>("Icons/chat_unclicked");
        //mapImage.sprite = Resources.Load<Sprite>("Icons/map_unclicked");
        //aidImage.sprite = Resources.Load<Sprite>("Icons/aid_unclicked");


        SceneManager.LoadScene(name);
    }
}
