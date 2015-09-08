using UnityEngine;
using System.Collections;

public class CanvasStats : MonoBehaviour 
{
	private bool _activeCanvas = false;
	private BaseUnit baseUnit;

	void Awake()
	{
		baseUnit = gameObject.GetComponentInParent<BaseUnit> ();
		baseUnit.ActionClicked += ShowStatsCanvas;
		this.gameObject.SetActive (false);
	}

	private void ShowStatsCanvas()
	{
		if (_activeCanvas == false) {
			//this.gameObject.SetActive (true);
			this.gameObject.SetActive(true);
			_activeCanvas = true;
		} else {
			this.gameObject.SetActive (false);
			_activeCanvas = false;
		}
	}

}
