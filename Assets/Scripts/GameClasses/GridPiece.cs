using UnityEngine;
using System.Collections;


public enum IOStreamDir{
	Null,
	Top,
	Bottom,
	Right,
	Left,
	TopRight,
	TopLeft,
	BottomRight,
	BottomLeft,
	LeftTop,
	LeftBottom,
	RightTop,
	RightBottom
}
		

public class GridPiece : MonoBehaviour {
	
	Grid myGrid;
	public Color myColor;

	private IOStreamDir InputOne;
	private IOStreamDir OutputOne;

	private IOStreamDir InputTwo;
	private IOStreamDir OutputTwo;


	public void SetStreamIO(IOStreamDir Ione, IOStreamDir Oone, IOStreamDir Itwo = IOStreamDir.Null, IOStreamDir Otwo = IOStreamDir.Null){
		InputOne = Ione;
		OutputOne = Oone;

		InputTwo = Itwo;
		OutputTwo = Otwo;

	}

	void OnDrawGizmosSelected() {
		
		Gizmos.color = myColor;
		Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
	}
}
