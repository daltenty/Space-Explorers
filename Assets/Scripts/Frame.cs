﻿using UnityEngine;
using System.Collections;

public class Frame : MonoBehaviour {
    Vector3 ScreenSize;
    public GameObject Cube;
	public GameObject LeftCube;
	public GameObject RightCube;
	public GameObject TopCube;
	public GameObject BottomCube;
	
	
	// Use this for initialization
	void Start () {
        ScreenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector3 Right = new Vector3(ScreenSize.x + .6f, 0, 0);
        Vector3 Left = -Right;
        Vector3 Top = new Vector3(0, ScreenSize.y + .6f, 0);
        Vector3 Bottom = -Top; 
        LeftCube = (GameObject)Instantiate(Cube, Left, Quaternion.identity);
        RightCube = (GameObject)Instantiate(Cube, Right, Quaternion.identity);
        TopCube = (GameObject)Instantiate(Cube, Top, Quaternion.identity);
        BottomCube = (GameObject)Instantiate(Cube, Bottom, Quaternion.identity);
        LeftCube.transform.localScale = new Vector3(1, 2*Top.y, 1);
        RightCube.transform.localScale = new Vector3(1, 2*Top.y, 1);
        TopCube.transform.localScale = new Vector3(2*Right.x, 1, 1);
        BottomCube.transform.localScale = new Vector3(2*Right.x, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
