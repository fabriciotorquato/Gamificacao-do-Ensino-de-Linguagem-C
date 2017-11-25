using UnityEngine;
using System.Collections;

public class controle : MonoBehaviour {
	public GameObject m1,m2,m3,botoes;
	

	public void desativarm1 () {
		m1.SetActive (false);
	}
	public void ativarm1 () {
		m1.SetActive (true);
	}
	public void desativarm2 () {
		m2.SetActive (false);
	}
	public void ativarm2 () {
		m2.SetActive (true);
	}
	public void desativarm3 () {
		m3.SetActive (false);
	}
	public void ativarm3 () {
		m3.SetActive (true);
	}
	public void desativarbotoes () {
		botoes.SetActive (false);
	}
	public void ativarbotoes () {
		botoes.SetActive (true);
	}
}
