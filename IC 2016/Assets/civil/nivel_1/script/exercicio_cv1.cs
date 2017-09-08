using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class exercicio_cv1 : MonoBehaviour {
	public GameObject[] ex=new GameObject[5];
	public int[] x = new int[5];
	public int[] y = new int[5];
	public GameObject vitoria,ponto;
	int controle;
	// Use this for initialization
	void Start () {
        controle = Random.Range (0, 4);
		ex [controle].SetActive (true);

		x[0]=-2;
		x[1]=-3;
		x[2]=2;
		x[3]=3;
		x[4]=-2;
		y[0]=6;
		y[1]=4;
		y[2]=4;
		y[3]=1;
		y[4]=1;
	}
	public void resposta()
	{
		movimento_cv1.rodar = true;
	}
	public void texto_vitoria()
	{
		if (x [controle] == compi.x && y [controle] == compi.y) {
			vitoria.GetComponent<Sair>().acertou=true;
            ponto.GetComponent<fase_ponto>().pontuacao();

        } else {
            vitoria.GetComponent<Sair>().acertou = false;
        }
        
    }
	
}
