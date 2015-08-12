using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using UnityEngine;
using JsonFx.Json;

[Serializable]
public class JSCISPConfig
{
	public string serverAddress;
	public int[] gemnumlist;
	public int[] giftnumlist;
	public float[] gemmoneylist;
	public float firstpay;
	public float payleveltime;
	public float payopentreasure;
	public float characterpack;
	public float resourcepack;
	public float skillpack;
	public float salepack;
	public float revive;
	public string characterpackcontent;

	public JSCISPConfig() { }
};