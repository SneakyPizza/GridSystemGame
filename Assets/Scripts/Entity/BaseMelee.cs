using UnityEngine;
using System.Collections;

public class BaseMelee : MonoBehaviour 
{
	protected int _health;
	protected int _attDmg;
	protected int _steps;
	protected bool _death = false;
	
	public int health
	{
		get{
			return _health;
		}
		set{
			_health = value;
		}
	}
	public int attDmg
	{
		get{
			return _attDmg;
		}
		set{
			_attDmg = value;
		}
	}

	public void SetDeath(bool death)
	{
		_death = death;
	}
}
