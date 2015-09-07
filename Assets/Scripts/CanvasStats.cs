using UnityEngine;
using System.Collections;

public class CanvasStats : MonoBehaviour 
{
	private bool _activeCanvas = false;
	private BaseUnit baseUnit;

	public void Start()
	{
		baseUnit.ActionClicked += ShowStatsCanvas;
	}

	private void ShowStatsCanvas()
	{
		if (_activeCanvas = false) {
			this.gameObject.SetActive (true);
			_activeCanvas = true;
		} else {
			this.gameObject.SetActive (false);
			_activeCanvas = false;
		}
	}

}
