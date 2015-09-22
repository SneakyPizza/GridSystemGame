using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour 
{
	[SerializeField]private Transform _tilePrefab;
	[SerializeField]private Transform _startPos;
	private Vector2 _gridSize = new Vector2 (10, 10);

	private int _gridX;
	private int _gridY;

	public void Start()
	{
		GenerateGrid ();
	}

	public void GenerateGrid()
	{
		Vector2 startPos = transform.position + _startPos.position; 
		startPos = new Vector2(Mathf.Round (startPos.x / _gridSize.x) * _gridSize.x, 
		                   Mathf.Round (startPos.y / _gridSize.y) * _gridSize.y);

	}

}
