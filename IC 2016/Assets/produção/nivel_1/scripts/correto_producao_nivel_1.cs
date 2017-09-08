using UnityEngine;
using System.Collections;

public class correto_producao_nivel_1 : MonoBehaviour {

	public GameObject caixa,texto;
	public string comando;

	public void OnMouseDown(){
		caixa.GetComponent<exercicio_producao_nivel_1> ().botao (comando);
	}
	public void OnMouseOver(){
		texto.SetActive (true);
	}
	public void OnMouseExit(){
		texto.SetActive (false);
	}
}
