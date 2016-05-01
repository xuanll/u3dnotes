//This script will only work in editor mode. You cannot adjust the scale dynamically in-game!
//该脚本只能在编辑器模式下使用。无法动态地在游戏进行中修改粒子缩放！
using UnityEngine;
using System.Collections;

//如果是编辑器模式，导入UnityEditor包
#if UNITY_EDITOR 
using UnityEditor;
#endif

/*
通常脚本只能在play模式下运行，增加[ExecuteInEditMode]属性，可以使脚本在edit模式下运行

The functions are not called constantly like they are in play mode.
- Update is only called when something in the scene changed.
- OnGUI is called when the Game View recieves an Event.
- OnRenderObject and the other rendering callback functions are called on every repaint of the Scene View or Game View.

*/
[ExecuteInEditMode]
public class ParticleScaler : MonoBehaviour 
{
	public float particleScale = 1.0f;
	public bool alsoScaleGameobject = true;

	float prevScale;

	void Start()
	{
		prevScale = particleScale;
	}

	//场景有变化时调用
	void Update () 
	{
#if UNITY_EDITOR 
		//check if we need to update
		//检查是否需要更新
		if (prevScale != particleScale && particleScale > 0)
		{
			if (alsoScaleGameobject)
				transform.localScale = new Vector3(particleScale, particleScale, particleScale);

			float scaleFactor = particleScale / prevScale;

			//scale legacy particle systems
			//缩放legacy粒子系统
			ScaleLegacySystems(scaleFactor);

			//scale shuriken particle systems
			//缩放shuriken粒子系统
			ScaleShurikenSystems(scaleFactor);

			//scale trail renders
			//缩放trail渲染
			ScaleTrailRenderers(scaleFactor);

			prevScale = particleScale;
		}
#endif
	}

	void ScaleShurikenSystems(float scaleFactor)
	{
#if UNITY_EDITOR 
		//get all shuriken systems we need to do scaling on
		//获取所有需要缩放的粒子系统
		ParticleSystem[] systems = GetComponentsInChildren<ParticleSystem>();

		foreach (ParticleSystem system in systems)
		{
			system.startSpeed *= scaleFactor;
			system.startSize *= scaleFactor;
			system.gravityModifier *= scaleFactor;

			//some variables cannot be accessed through regular script, we will acces them through a serialized object
			//有些属性无法通过常规脚本访问，这里使用序列化对象访问
			SerializedObject so = new SerializedObject(system);
			
			//unity 4.0 and onwards will already do this one for us
			//unity 4.0以上版本已经加入了下列处理
#if UNITY_3_5 
			so.FindProperty("ShapeModule.radius").floatValue *= scaleFactor;
			so.FindProperty("ShapeModule.boxX").floatValue *= scaleFactor;
			so.FindProperty("ShapeModule.boxY").floatValue *= scaleFactor;
			so.FindProperty("ShapeModule.boxZ").floatValue *= scaleFactor;
			
#endif
			
			so.FindProperty("VelocityModule.x.scalar").floatValue *= scaleFactor;
			so.FindProperty("VelocityModule.y.scalar").floatValue *= scaleFactor;
			so.FindProperty("VelocityModule.z.scalar").floatValue *= scaleFactor;
			so.FindProperty("ClampVelocityModule.magnitude.scalar").floatValue *= scaleFactor;
			so.FindProperty("ClampVelocityModule.x.scalar").floatValue *= scaleFactor;
			so.FindProperty("ClampVelocityModule.y.scalar").floatValue *= scaleFactor;
			so.FindProperty("ClampVelocityModule.z.scalar").floatValue *= scaleFactor;
			so.FindProperty("ForceModule.x.scalar").floatValue *= scaleFactor;
			so.FindProperty("ForceModule.y.scalar").floatValue *= scaleFactor;
			so.FindProperty("ForceModule.z.scalar").floatValue *= scaleFactor;
			so.FindProperty("ColorBySpeedModule.range").vector2Value *= scaleFactor;
			so.FindProperty("SizeBySpeedModule.range").vector2Value *= scaleFactor;
			so.FindProperty("RotationBySpeedModule.range").vector2Value *= scaleFactor;

			so.ApplyModifiedProperties();
		}
#endif
	}

	void ScaleLegacySystems(float scaleFactor)
	{
#if UNITY_EDITOR 
		//get all emitters we need to do scaling on
		//获取所有需要缩放的例子发射器
		ParticleEmitter[] emitters = GetComponentsInChildren<ParticleEmitter>();

		//get all animators we need to do scaling on
		//获取所有需要缩放的animator,ParticleAnimator粒子动画
		ParticleAnimator[] animators = GetComponentsInChildren<ParticleAnimator>();

		//apply scaling to emitters
		foreach (ParticleEmitter emitter in emitters)
		{
			emitter.minSize *= scaleFactor;
			emitter.maxSize *= scaleFactor;
			emitter.worldVelocity *= scaleFactor;
			emitter.localVelocity *= scaleFactor;
			emitter.rndVelocity *= scaleFactor;

			//some variables cannot be accessed through regular script, we will acces them through a serialized object
			//序列化对象访问特殊属性
			SerializedObject so = new SerializedObject(emitter);

			so.FindProperty("m_Ellipsoid").vector3Value *= scaleFactor;
			so.FindProperty("tangentVelocity").vector3Value *= scaleFactor;
			so.ApplyModifiedProperties();
		}

		//apply scaling to animators
		foreach (ParticleAnimator animator in animators)
		{
			animator.force *= scaleFactor;
			animator.rndForce *= scaleFactor;
		}
#endif
	}

	void ScaleTrailRenderers(float scaleFactor)
	{
		//get all animators we need to do scaling on
		//获取所有需要缩放的animator, TrailRenderer拖痕渲染器
		TrailRenderer[] trails = GetComponentsInChildren<TrailRenderer>();

		//apply scaling to animators
		foreach (TrailRenderer trail in trails)
		{
			trail.startWidth *= scaleFactor;
			trail.endWidth *= scaleFactor;
		}
	}
}
