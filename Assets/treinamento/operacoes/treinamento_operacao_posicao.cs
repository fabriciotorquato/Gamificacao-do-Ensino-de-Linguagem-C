using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class treinamento_operacao_posicao : MonoBehaviour {
	public static float[,] posicao = new float[7, 2];
	public static float px;
	public static int[] comp=new int[7];
	public int[] textx = new int[7];
	public GameObject[] opcao = new GameObject[6];
		int i;
	void Start () {
		for(i=0;i<7;i++)
		{
			posicao[i,0]=-1;
			comp [i] = -1;
		}
		px= opcao[0].transform.position.x;
		posicao[0,1]=opcao[5].transform.position.y;
		posicao[1,1]=opcao[4].transform.position.y;
		posicao[2,1]=opcao[3].transform.position.y;
		posicao[3,1]=opcao[2].transform.position.y;
		posicao[4,1]=opcao[1].transform.position.y;
		posicao[5,1]=opcao[0].transform.position.y;
		posicao[6,1]=0f;
	}
	
	// Update is called once per frame
	void Update () {
		textx[0]=comp [0];
		textx[1]=comp [1];
		textx[2]=comp [2];
		textx[3]=comp [3];
		textx[4]=comp [4];
		textx[5]=comp [5];
		textx[6]=comp [6];
	
	}
}
