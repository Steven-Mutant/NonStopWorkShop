using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SerializeField]
public class Grid : MonoBehaviour {

	private static Grid _gridInstace;

	GameObject[,] myGridPieces;

	public int gridHeight = 5;
	public int gridWidth = 5;

	float offSet = 1.2f;

	public List<GridPiece> myGridPieceComponenets = new List<GridPiece>();

	
	// Use this for initialization



	public void SetGrid () {

		if (_gridInstace == null) {
			_gridInstace = this;
		} else {
			Destroy(this.gameObject);
		}

	}


	public static Grid GetGrid(){
		if (_gridInstace == null) {
			Debug.LogError("Don't forget to run set Grid after creating it");
			return null;
		}

		return _gridInstace;
	}


	public void PopulateGrid(int height, int width){

		myGridPieces = new GameObject[height, width];
		GameObject workingObj = null;


		for (int gridY = 0; gridY < height; gridY++) {
			GameObject myParent = new GameObject();
			myParent.transform.SetParent(this.transform);
			myParent.transform.name = "Row" + gridY.ToString();
			for (int gridX = 0; gridX < width; gridX++) {
				myGridPieces[gridY, gridX] = new GameObject();
				workingObj = myGridPieces[gridY, gridX];
				workingObj.transform.SetParent(myParent.transform);
				workingObj.transform.position = new Vector3(gridX * offSet, 0f, gridY * offSet * -1f);
				workingObj.transform.name = "GridPiece " + gridX.ToString();
				GridPiece thisPiece = workingObj.AddComponent<GridPiece>();
				thisPiece.myColor = new Color(gridX * 0.1f, 0.2f, gridY * 0.1f);
				myGridPieceComponenets.Add(thisPiece);





			}

		}



	}
	

}
