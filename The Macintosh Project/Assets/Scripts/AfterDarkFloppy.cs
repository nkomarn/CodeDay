using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfterDarkFloppy : MonoBehaviour
{

	public Sprite enabled;
	public Sprite disabled;
	public Button floppy;
	
	// Use this for initialization
	void Start ()
	{
		Button floppyButton = floppy.GetComponent<Button>();
		floppyButton.onClick.AddListener(insertFloppy);
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.afterDarkFloppyInserted == false)
		{
			floppy.gameObject.SetActive(true);
		}
	}

	void insertFloppy()
	{
		if (GlobalVariables.floppyInDrive == false)
		{
			Button floppyButton = floppy.GetComponent<Button>();
			floppyButton.enabled = false;
			floppyButton.image.sprite = disabled;

			GlobalVariables.afterDarkFloppyInserted = true;
		}
		
	}
}
