using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HelpBotton : MonoBehaviour
{
    //操作説明のUI
    [SerializeField]
    GameObject helpUI;

    
    public void OpenClick()
    {
        //操作説明のUIの表示
        helpUI.gameObject.SetActive(true);
    }

    public void CloseClick()
    {
        //操作説明のUIの非表示
        helpUI.gameObject.SetActive(false);
    }
}
