using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class treinamento_operacao_compilador : MonoBehaviour {
	
	int an;
	public int i;	
	public Text erro;
	public GameObject tradutor;


	public void compilavel()
	{
		erro.text = "";
			
		an = tradutor.GetComponent<tradutor_C_operacao> ().comparacao [0];
		if (an != 4)
			erro.text = "Variavel não declarada";
		else {
			an = tradutor.GetComponent<tradutor_C_operacao> ().comparacao [1];
			if (an != 1 && an != 3)
				erro.text = "Variavel contem lixo de memoria";
			else {
				an = tradutor.GetComponent<tradutor_C_operacao> ().comparacao [2];
				if (an != 1 && an != 3)
					erro.text = "Variavel contem lixo de memoria";
				else
					erro.text = "Erro de logica";
			}
		}
	}
}
