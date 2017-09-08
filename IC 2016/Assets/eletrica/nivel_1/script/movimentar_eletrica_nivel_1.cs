using UnityEngine;
using System.Collections;

public class movimentar_eletrica_nivel_1 : MonoBehaviour {

	public GameObject bancada;
	public int ant,nv,botao;
	public Animator anim;

	void Start () {
		ant = -1;
		nv = -1;
		anim = GetComponent <Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		nv = bancada.GetComponent<apertou_eletrica_nivel_1> ().local [botao];
		if (ant != nv) {
			ant = nv;
			anim.SetInteger("valor",nv);
		}
	}
}
