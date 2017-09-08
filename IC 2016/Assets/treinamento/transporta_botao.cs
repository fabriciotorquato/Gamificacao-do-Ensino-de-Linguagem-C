using UnityEngine;
using System.Collections;

public class transporta_botao : MonoBehaviour {

	public GameObject [] condicao = new GameObject[3];
	public GameObject [] opcao = new GameObject[9];
	public bool [] b_condicao = new bool[3];
	public int [] b_opcao = new int[9];
	public int i,j;
	public string nome;
	public int pos;
	void Start () {
		for (i = 0; i < 3; i++)
			b_condicao[i] = false;
		for (i = 0; i < 9; i++)
			b_opcao[i] = -1;
	}
		

	public void apertou(GameObject botao){  
		nome = botao.transform.FindChild ("Text").tag;
		int.TryParse(nome,out i);
		if(b_opcao[i]==-1){
			if(b_condicao[0]==false){
					botao.transform.position = condicao[0].transform.position;
					b_condicao[0]=true;
					b_opcao[i]=0;
			}else if(b_condicao[1]==false){
					botao.transform.position = condicao[1].transform.position;
					b_condicao[1]=true;
					b_opcao[i]=1;
			}else if(b_condicao[2]==false){
					botao.transform.position = condicao[2].transform.position;
					b_condicao[2]=true;
					b_opcao[i]=2;
			}
		}else{
			b_condicao [b_opcao[i]] = false;
			botao.transform.position = opcao[i].transform.position;
			b_opcao[i]=-1;
		}

	}
}
