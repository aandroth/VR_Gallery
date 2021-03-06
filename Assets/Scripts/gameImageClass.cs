﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameImageClass : MonoBehaviour {

    public string[] filters;
    string fileDir;
    string gameDir;
    public Image imgPtr, img_Test;
    public Sprite spr_Test;
    int width = 101, height = 52;
    public Texture2D tex2d_Test;

    // Use this for initialization
    void Start ()
    {
        imgPtr = GetComponent<Image>();
    }

    public void SetDir(string dirStr)
    {
        fileDir = dirStr;
    }

    public void FillValues(string gameName)
    {
        gameDir = gameName;
        //gameName = gameName.Replace('\\', '/');
        filters = System.IO.File.ReadAllLines(gameName + "/Tags.txt");
        //Debug.Log(gameName.Substring(19) + "/Banner");
        //Debug.Log(gameName + "/Banner");
        imgPtr = Resources.Load<Image>(gameDir + "/Banner");
    }
}
