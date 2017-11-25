using UnityEngine;
using System.Collections;

public class treinamento_operacao_pos : MonoBehaviour {

	float px,py;
	int pos,con,controle;
	void Start () {
		px = transform.position.x;
		py = transform.position.y;
		Debug.Log ("x: "+px.ToString());
		Debug.Log ("y: "+py.ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
