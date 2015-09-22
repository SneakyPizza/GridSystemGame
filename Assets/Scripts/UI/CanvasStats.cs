using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasStats : MonoBehaviour 
{
	private bool _activeCanvas = false;
	private BaseUnit baseUnit;

	public Text _attStatText;
	public Text _hpStatText;



	void Awake()
	{
		baseUnit = gameObject.GetComponentInParent<BaseUnit> ();
		baseUnit.ActionClicked += ShowStatsCanvas;
		this.gameObject.SetActive (false);

		_attStatText = gameObject.GetComponentInParent<Text> ();
		_hpStatText = gameObject.GetComponentInParent<Text> ();

		//_attStatText.text = "Att : " + att;
		//_hpStatText.text = "HP : " + hp;
	}

	private void ShowStatsCanvas()
	{
		//Turning the Canvas on / off
		if (_activeCanvas == false) 
		{
			this.gameObject.SetActive(true);
			_activeCanvas = true;
		} else {
			this.gameObject.SetActive (false);
			_activeCanvas = false;
		}


	}

}
