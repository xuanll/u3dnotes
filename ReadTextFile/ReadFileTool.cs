using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JsonFx.Json;

public class ReadFileTool : MonoBehaviour
{
	
	static public T JsonToClass<T>(string json) where T : class
	{
		T t = JsonReader.Deserialize<T>(json);
		return t;
	}
	
	static public T AddressToClass<T>(string txtAddress) where T : class
	{
		TextAsset jsonData = Resources.Load(txtAddress) as TextAsset;
		return JsonToClass<T>(jsonData.text);
	}
	
	static public T[] JsonToClasses<T>(string json) where T : class
	{
		//Debug.Log(json);
		T[] list = JsonReader.Deserialize<T[]>(json);
		return list;
	}
	
	static public T[] AddressToClasses<T>(string txtAddress) where T : class
	{
		TextAsset jsonData = Resources.Load(txtAddress) as TextAsset;
		return JsonToClasses<T>(jsonData.text);
	}
}

