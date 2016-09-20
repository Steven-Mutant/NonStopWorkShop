using UnityEngine;
using System.Collections;

public class SpawnGrid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject myGrid = new GameObject ();
		myGrid.transform.name = "Grid";
		Grid myGridComp = myGrid.AddComponent<Grid> ();
		myGridComp.SetGrid ();
		myGridComp.PopulateGrid (50,50);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
