using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class tirar_botao : MonoBehaviour {
	public GameObject botao;
	public int pos;
	public Text frase;

	public void tirar()
	{
		botoes.livre[pos] = 0;
		conta ();
		compi.sequencia [pos] = 0;
		botoes.tentativas = botoes.tentativas + 1;
		botao.SetActive (false);
	}

	public void conta()
	{
		if (frase.text == "Norte") {
			compi.y = compi.y - 1;
		}
		if (frase.text == "Sul") {
			compi.y = compi.y + 1;
		}
		if (frase.text == "Leste") {
			compi.x = compi.x + 1;
		}
		if (frase.text == "Oeste") {
			compi.x = compi.x - 1;
		}
	}
	

}
