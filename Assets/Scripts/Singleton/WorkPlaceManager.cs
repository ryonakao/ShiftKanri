﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//バイト先情報を格納するクラス
public class WorkPlaceManager : SingletonMonoBehaviour<WorkPlaceManager> {
	/*
	//保存したバイト先の名前
	public List<string> workPlaceNames = new List<string>();

	void Start()
	{
		ReadNames ();
	}
	//保存された名前を読み込み
	public void ReadNames()
	{
		workPlaceNames = PlayerPrefsUtility.LoadList<string> ("name");
	}
	//======ここではバイト先の名前のみをListで保存している
	//バイト先名を保存
	public void SaveNames(string name)
	{
		Debug.Log ("バイト先名保存");
		workPlaceNames.Add (name);
		PlayerPrefsUtility.SaveList<string> ("name", workPlaceNames);
	}
	*/
}
