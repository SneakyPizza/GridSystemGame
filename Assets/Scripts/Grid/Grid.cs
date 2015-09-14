using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	private Vector2 _gridSize = new Vector2 (10, 10);

	private int _gridX;
	private int _gridY;

	public void Start()
	{
		GenerateGrid ();
	}

	public void GenerateGrid()
	{

	}

}
