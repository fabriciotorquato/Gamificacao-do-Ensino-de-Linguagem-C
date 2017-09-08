using UnityEngine;
using System.Collections;

public class apertou_eletrica_nivel_1 : MonoBehaviour {

	public GameObject[] plug = new GameObject[10];
	public GameObject[] pino = new GameObject[2];
	public int[] local = new int[2];
	public int i;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void apertou_plug(GameObject plug){
		if (local [0] == -1) {
			int.TryParse(plug.name,out local [0]);


		} else if(local[1]==-1){
			int.TryParse(plug.name,out local [1]);

		}	
	}
	public void apertou_pino (GameObject pino){
			int.TryParse (pino.name, out i);
			local [i] = -1;
	}
}
