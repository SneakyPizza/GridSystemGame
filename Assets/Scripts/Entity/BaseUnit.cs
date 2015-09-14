using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BaseUnit : MonoBehaviour 
{
	protected int _health;
	protected int _fieldOfView;

	protected bool _death = false;
	private bool _statsActive = false;

	public delegate void ClickAction ();
	public event ClickAction ActionClicked;
	
	public int health
	{
		get{
			return _health;
		}
		set{
			_health = value;
		}
	}

	public void SetDeath(bool death)
	{
		_death = death;
	}

 	public void OnMouseDown()
	{
		if (gameObject.tag == "Unit") 
		{
			if (ActionClicked != null)
			{
				ActionClicked();
			}


		}
	}
	
}
