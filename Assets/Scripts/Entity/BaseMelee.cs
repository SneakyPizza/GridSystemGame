using UnityEngine;
using System.Collections;

public class BaseMelee : BaseUnit 
{
	protected int _attDmg;
	protected int _steps;
	
	public int attDmg
	{
		get{
			return _attDmg;
		}
		set{
			_attDmg = value;
		}
	}


}
