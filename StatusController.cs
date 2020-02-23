using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusController : MonoBehaviour
{
    
    public Button mod;
    public Button eme;
    public Image moderate;
    public Image emergency;


    public Button plus;
    public Button minus;
    public Button exit;
    public Text comments;
    public Text numPeople;
    int num;

    public Button confirm;
    public Button safe;

    public Image status;

    CanvasGroup cg;

    bool isMod = false;
    // Start is called before the first frame update
    void Start()
    {
        cg = GetComponent<CanvasGroup>();
        mod.onClick.AddListener(delegate { SelectSeverity("moderate"); });
        eme.onClick.AddListener(delegate { SelectSeverity("emergency"); });
        num = 0;
        plus.onClick.AddListener(delegate { NumPeople("+"); });
        minus.onClick.AddListener(delegate { NumPeople("-"); });
        exit.onClick.AddListener(Hide);
        confirm.onClick.AddListener(ConfirmForm);
        safe.onClick.AddListener(ConfirmSafe);

        cg.alpha = 0f;
        cg.interactable = false;
        cg.blocksRaycasts = false;
        //Debug.Log("once");
    }

    void SelectSeverity(string input)
    {
        if (input == "moderate")
        {
            moderate.sprite = Resources.Load<Sprite>("Icons/Selected");
            emergency.sprite = Resources.Load<Sprite>("Icons/Deselected");
            isMod = true;
        } else if (input == "emergency")
        {
            emergency.sprite = Resources.Load<Sprite>("Icons/Selected");
            moderate.sprite = Resources.Load<Sprite>("Icons/Deselected");
            isMod = false;
        }
    }

    void NumPeople(string input)
    {
        if (input == "+")
        {
            num++;
        }
        else if(input == "-")
        {
            if (num > 1)
            {
                num--;
            }
        }
        numPeople.text = num.ToString();
    }

    void Hide()
    {
        cg.blocksRaycasts = false;
        cg.alpha = 0.0f;
        cg.interactable = false;
        //Debug.Log("pnly other");
    }

    void ConfirmForm()
    {
        if (isMod)
        {
            status.sprite = Resources.Load<Sprite>("BadgeImages/NeedsHelp");
        } else
        {
            status.sprite = Resources.Load<Sprite>("BadgeImages/NeedsHelp2");
        }
        ProfileController.comments = comments.text;
        ProfileController.numPeople = int.Parse(numPeople.text);
        Hide();
    }

    void ConfirmSafe()
    {
        status.sprite = Resources.Load<Sprite>("BadgeImages/Safe");
        Hide();
    }
}
