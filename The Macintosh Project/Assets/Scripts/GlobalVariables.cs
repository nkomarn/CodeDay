using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

	public static bool floppyInserted;
	public static bool afterDarkFloppyInserted;
	public static bool floppyInDrive;
	
	
	// Use this for initialization
	void Start ()
	{
		floppyInserted = false;
		afterDarkFloppyInserted = false;
		floppyInDrive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
