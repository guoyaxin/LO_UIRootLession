using UnityEngine;
using System.Collections;

public class CreatUIRoot : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		CreatRoot ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void CreatRoot ()
	{
		UIPanel panl = NGUITools.CreateUI (false);
		UIRoot root = panl.GetComponent<UIRoot> ();
		root.scalingStyle = UIRoot.Scaling.Flexible;
		root.minimumHeight = 320;
		root.maximumHeight = 960;
		root.shrinkPortraitUI = true;
		root.adjustByDPI = true;

	}
}
