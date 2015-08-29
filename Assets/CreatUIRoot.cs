using UnityEngine;
using System.Collections;

public class CreatUIRoot : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		CreatRoot ();
	}

	/**
	 * 创建UIRoot
	 */
	void CreatRoot ()
	{
		//通过创建UIPanel来创建UIRoot
		UIPanel panl = NGUITools.CreateUI (false);
		UIRoot root = panl.GetComponent<UIRoot> ();
		//设置UIRoot的缩放模式为Flexible
		root.scalingStyle = UIRoot.Scaling.Flexible;
		//设置最小高度
		root.minimumHeight = 320;
		//设置最大高度
		root.maximumHeight = 960;
		//设置UIRoot当屏幕为竖直方向时，缩放UI
		root.shrinkPortraitUI = true;
		//设置UIRoot的屏幕适配为像素
		root.adjustByDPI = true;
	}
}
