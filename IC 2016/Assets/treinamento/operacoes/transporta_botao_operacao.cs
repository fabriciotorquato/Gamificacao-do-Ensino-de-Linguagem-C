using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class transporta_botao_operacao : MonoBehaviour {

	public GameObject [] condicao = new GameObject[4];
	public GameObject [] opcao = new GameObject[6];
	public bool [] b_condicao = new bool[4];
	public int [] b_opcao = new int[6];
	public int i,j;
	public string nome;
	public int pos;

	void Start () {
		for (i = 0; i < 4; i++)
			b_condicao[i] = false;
		for (i = 0; i < 6; i++)
			b_opcao [i] = -1;

	}


	public void apertou(GameObject botao){  
		nome = botao.transform.FindChild ("Text").tag;
		int.TryParse(nome,out i);
		if (b_opcao [i] == -1) {
			botao.GetComponent<mover_botao> ().cod = i;
			if (b_condicao [0] == false) {
				botao.transform.position = condicao [0].transform.position;
				b_condicao [0] = true;
				b_opcao [i] = 0;
			} else if (b_condicao [1] == false) {
				botao.transform.position = condicao [1].transform.position;
				b_condicao [1] = true;
				b_opcao [i] = 1;
			} else if (b_condicao [2] == false) {
				botao.transform.position = condicao [2].transform.position;
				b_condicao [2] = true;
				b_opcao [i] = 2;
			} else if (b_condicao [3] == false) {
				botao.transform.position = condicao [3].transform.position;
				b_condicao [3] = true;
				b_opcao [i] = 3;
				}
			botao.GetComponent<mover_botao> ().cod = b_opcao [i];
			} else {
				botao.GetComponent<mover_botao> ().cod = -1;
				b_condicao [b_opcao [i]] = false;
				botao.transform.position = opcao [i].transform.position;
				b_opcao [i] = -1;
			}
	}
}
