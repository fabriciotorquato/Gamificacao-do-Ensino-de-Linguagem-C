using UnityEngine;
using System.Collections;

public class mover_botao : MonoBehaviour {

	public bool clicou;
	public GameObject botao;
	public Vector3 anterior;
	public int cod=-1;

	void Start () {
	}

	void Update () {
		if (clicou) {
			botao.transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
			anterior = Input.mousePosition;
		}
	}

	public void apertou(){  
		if (clicou)
			clicou = false;
		else
			clicou = true;

	}
}
