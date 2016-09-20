using UnityEngine;
using System.Collections;

public class GridPiece : MonoBehaviour {

	Grid myGrid;

	public Color myColor;




	void OnDrawGizmosSelected() {




		Gizmos.color = myColor;
		Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
	}
}
