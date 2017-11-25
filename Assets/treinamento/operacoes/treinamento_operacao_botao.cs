using UnityEngine;
using System.Collections;

public class treinamento_operacao_botao : MonoBehaviour {
	public static int[,] pos = new int[7,3];
	public int cod;
	int con,controle,ik;
	float px,py;
	void Start () {
		px = transform.position.x;
		py = transform.position.y;

	}

	void Update () {

	}
	public void apertou()
	{
		if (con == 0) {
			con = -1;
			for (ik = 0; ik < 6; ik++) {
				if (treinamento_operacao_posicao.posicao [ik, 0] == -1 || treinamento_operacao_posicao.posicao [ik, 0] == 0) {
					controle = ik;	

				}
			}
			transform.position = new Vector3 (treinamento_operacao_posicao.px,treinamento_operacao_posicao.posicao[controle,1],transform.position.z);
			treinamento_operacao_posicao.comp [controle] = cod;
			treinamento_operacao_posicao.posicao [controle, 0] = 1;
		} else {
			con = 0;
			transform.position = new Vector3 (px,py,transform.position.z);	
			treinamento_operacao_posicao.comp [controle] =0;
			treinamento_operacao_posicao.posicao [controle, 0] =0;

		}


	}
}
