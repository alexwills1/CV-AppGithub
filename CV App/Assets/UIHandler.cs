using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour{

    public GameObject ScrollCV;
    public GameObject Home;

   public void buttonEvent()
    {
            ScrollCV.SetActive(true);
    }

    public void buttonEvent2()
    {
            Home.SetActive(true);
    }
}
