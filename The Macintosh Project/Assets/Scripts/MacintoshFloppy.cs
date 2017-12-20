using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class MacintoshFloppy : MonoBehaviour
{

	public Sprite noFloppy;
	public Sprite floppyInserted;
	public Sprite looking1;
	public Sprite looking2;
	public Sprite guidedTour;

	public Button Edesk;
	public Button Finder;
	public Button Windows;
	public Button Menus;
	public Button Maze;

	public Button Mousing;
	public Button Use;
	public Button Stop;

	public int count = 1;
	public int count2 = 1;

	public SpriteRenderer rend;
	public Canvas macintoshCanvas;
	
	// Floppy Looker
	IEnumerator Look()
	{
		count = count + 1;
		yield return new WaitForSeconds(1.0f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(1.0f);
		rend.sprite = guidedTour;
		yield return new WaitForSeconds(0.5f);
		Edesk.gameObject.SetActive(true);
		Mousing.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		Finder.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		Windows.gameObject.SetActive(true);
		Use.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		Menus.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		Maze.gameObject.SetActive(true);
		Stop.gameObject.SetActive(true);
	}

	IEnumerator floppyNotBoootable()
	{
		count2 = count2 + 1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking1;
		yield return new WaitForSeconds(0.5f);
		rend.sprite = looking2;
	}

	// Use this for initialization
	void Start ()
	{
		rend.GetComponent<SpriteRenderer>();
		rend.sprite = noFloppy;

		Edesk.gameObject.SetActive(false);
		Finder.gameObject.SetActive(false);
		Windows.gameObject.SetActive(false);
		Menus.gameObject.SetActive(false);
		Maze.gameObject.SetActive(false);
		Mousing.gameObject.SetActive(false);
		Use.gameObject.SetActive(false);
		Stop.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalVariables.floppyInserted == true && count == 1)
		{
			rend.sprite = floppyInserted;
			StartCoroutine(Look());
		}
		if (GlobalVariables.floppyInserted == false)
		{
			rend.sprite = noFloppy;
		}

		if (GlobalVariables.afterDarkFloppyInserted == true && count2 == 1)
		{
			count2 = count2 + 1;
			StartCoroutine(floppyNotBoootable());
		}
	}
}

