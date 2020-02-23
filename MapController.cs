using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public MapIconController a;
    public MapIconController b;
    public MapIconController c;

    public void Yes()
    {
        //Debug.Log("herli");
        a.Clear();
        b.Clear();
        c.Clear();
    }
}
