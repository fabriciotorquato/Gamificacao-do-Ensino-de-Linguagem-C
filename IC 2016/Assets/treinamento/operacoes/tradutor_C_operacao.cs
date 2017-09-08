using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tradutor_C_operacao : MonoBehaviour {

	public int aux,i,j,aux_2,c,flag;
	public GameObject copilador,botao,perguntas,linha;
	public GameObject[] apertar = new GameObject[6];
	public Text pergunta;
	public string[] condicao = new string[4];
	public Text sucesso;
	public int [] comparacao = new int[4];
    public GameObject vitoria,ponto;

	void Start () {

		copilar (1);
	}


	void Update () {

	}
	public void copilar(int cont){
		for (i = 0; i < 4; i++) 
			condicao [i] = "\n";
		if(cont!=1)
			for (i = 0,c=0; i < 6; i++) {
				aux = botao.GetComponent<transporta_botao_operacao> ().b_opcao [i];
				if (aux != -1) {
					for (j = 0; j < 6; j++) {
						int.TryParse(apertar [j].transform.FindChild ("Text").tag,out aux_2);
						if (i == aux_2) {
							condicao [aux] = "\t\t";
							condicao [aux] += apertar [j].transform.FindChild("Text").GetComponent<Text> ().text;
							condicao [aux] += "\n";
							comparacao [aux] = apertar[j].GetComponent<treinamento_operacao_botao>().cod;
							c++;
							break;
						}
					}
				}
			}
		if (c==4 || cont == 1) {
            linha.GetComponent<comp_operacao>().contador_linha[4].GetComponent<Text>().text = "5\t"+ condicao[0];
            linha.GetComponent<comp_operacao>().contador_linha[5].GetComponent<Text>().text ="6\t" + condicao[1];
            linha.GetComponent<comp_operacao>().contador_linha[6].GetComponent<Text>().text = "7\t" + condicao[2];
            linha.GetComponent<comp_operacao>().contador_linha[7].GetComponent<Text>().text = "8\t" + condicao[3];
        }
		if (c == 4) {
			flag = 0;
			for (i = 0; i < 4; i++) {
				if (comparacao [i] != perguntas.GetComponent<treinamento_operacao_problemas> ().teste [0, i])
					flag = 1;
			}
			if (flag == 0) {
                vitoria.GetComponent<Sair>().acertou = true;
                ponto.GetComponent<fase_ponto>().pontuacao();
                sucesso.text = "Sintaxe Correta";
				linha.GetComponent<comp_operacao> ().gat = 1;
				return;
			}
			flag = 0;
			for (i = 0; i < 4; i++) {
				if (comparacao [i] != perguntas.GetComponent<treinamento_operacao_problemas> ().teste [1, i])
					flag = 1;
			}
			if (flag == 0) {
                vitoria.GetComponent<Sair>().acertou = true;
                ponto.GetComponent<fase_ponto>().pontuacao();
                sucesso.text = "Sintaxe Correta";
				linha.GetComponent<comp_operacao> ().gat = 1;
			}
		}
	}
}
