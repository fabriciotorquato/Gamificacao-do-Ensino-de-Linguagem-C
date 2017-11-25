using UnityEngine;
using System.Collections;

public class caixa_producao_nivel_1 : MonoBehaviour {

	public Animator anim;

	void Start () {
		anim = GetComponent <Animator>();
	}
		
	public void ativar (bool comando) {
		anim.SetBool("possitivo",comando);
		ligar (false);
	}
	public void ligar(bool comando) {
		anim.SetBool("iniciar",comando);
	}
}
