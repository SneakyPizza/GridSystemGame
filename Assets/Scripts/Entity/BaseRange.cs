using UnityEngine;
using System.Collections;

public class BaseRange : BaseUnit 
{
	protected int _steps;
	protected int _rangeDmg;

	public int rangeDmg
	{
		get{
			return _rangeDmg;
		}
		set{
			_rangeDmg = value;
		}
	}
}
