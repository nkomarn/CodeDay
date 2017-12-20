using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chime : MonoBehaviour
{
	public AudioSource chime;
	public bool audioEnabled;
	
	// Use this for initialization
	void Start ()
	{
		audioEnabled = GlobalVariables.floppyInserted;
	}
	
	// Update is called once per frame
	void Update () {
		if (audioEnabled == true)
		{
			chime.Play();
			audioEnabled = false;
		}
		if (GlobalVariables.floppyInserted == false)
		{
			chime.Pause();
		}
	}
}
