using UnityEngine;
using System.Collections;

public class iniciar_producao_nivel_1 : MonoBehaviour {
	public GameObject caixa;

	void OnTriggerEnter(Collider other){
		Debug.Log ("entrou");
		caixa.GetComponent<exercicio_producao_nivel_1> ().iniciar ();
	}
}
