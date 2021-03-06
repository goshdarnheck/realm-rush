using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
	
	Color exploredColor = Color.cyan;
	
	public bool isExplored = false;
	public Waypoint exploredFrom;

	const int gridSize = 10;

	public int GetGridSize() {
		return gridSize;
	}

	public Vector2Int GetGridPos() {
		return new Vector2Int(
			Mathf.RoundToInt(transform.position.x / gridSize),
			Mathf.RoundToInt(transform.position.z / gridSize)
		);
	}

	public void SetTopColor(Color color) {
		MeshRenderer topMeshRenderer = transform.Find("Top").GetComponent<MeshRenderer>();
		topMeshRenderer.material.color = color;
	}

	private void Update() {
		if (exploredFrom != null) {
			SetTopColor(exploredColor);
		}
	}
}
