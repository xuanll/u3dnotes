using UnityEngine;
using System;
using System.Collections;

class dummy: MonoBehaviour { void Start() {} void Update() {} }

public class DelayExecute
{
	static private MonoBehaviour _placeholder = null;
	static private MonoBehaviour _this
	{
		get
		{
			if (_placeholder == null)
			{
				GameObject obj = new GameObject("DelayExecute");
				_placeholder = obj.AddComponent<dummy>();
			}
			
			return _placeholder;
		}
	}
	
	public static void Perform(float delay, Action fn)
	{
		_this.StartCoroutine(doPerform(delay, fn));
	}
	
	private static IEnumerator doPerform(float delay, Action fn)
	{
		yield return new WaitForSeconds (delay);
		fn();
	}
	
	public static void Repeat(float delay, Func<bool> fn)
	{
		_this.StartCoroutine(doRepeat(delay, fn));
	}
	
	public static IEnumerator doRepeat(float delay, Func<bool> fn)
	{
		bool repeat = true;
		while (repeat)
		{
			repeat = fn();
			yield return new WaitForSeconds(delay);
		}
	}
	
	public static void Repeat(float delay, Func<float> fn)
	{
		_this.StartCoroutine(doRepeat(delay, fn));
	}
	
	public static IEnumerator doRepeat(float delay, Func<float> fn)
	{
		while (true)
		{
			float next = fn();
			if (next < 0)
				yield break;
			else
				yield return new WaitForSeconds(next);
		}
	}
	
	public static void Destory()
	{
		_this.StopAllCoroutines();
		GameObject.Destroy(_this.gameObject);
	}
}
