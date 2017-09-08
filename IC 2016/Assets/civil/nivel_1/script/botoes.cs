using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class botoes : MonoBehaviour {
	public GameObject[] pos=new GameObject[12];
	public Text[] texto = new Text[12];
	public static int [] livre=new int[13];
	public static int tentativas;
	public Text chances;
	int i,local;
	void Start () {
		for (i = 0; i < 12; i++) {
			livre [i] = 0;
		}
		livre [12] = -1;
		tentativas = 12;

	}

	public void cima()
	{
		local = posicao();
		if (local != -1) {
			pos [local].SetActive (true);
			texto[local].text="Norte";
			compi.y=compi.y+1;
			compi.sequencia [local] = 1;
			tentativas--;
			atualizar ();
		}
	}
	public void baixo()
	{
		local = posicao();
		if (local != -1) {
			pos [local].SetActive (true);
			texto[local].text="Sul";
			compi.y=compi.y-1;
			compi.sequencia [local] = 2;
			tentativas--;
			atualizar ();
		}
	}
	public void esquerda()
	{
		local = posicao();
		if (local != -1) {
			pos [local].SetActive (true);
			texto[local].text="Leste";
			compi.x=compi.x-1;
			compi.sequencia [local] = 3;
			tentativas--;
			atualizar ();
		}
	}
	public void direita()
	{
		local = posicao();
		if (local != -1) {
			pos [local].SetActive (true);
			texto[local].text="Oeste";
			compi.x=compi.x+1;
			compi.sequencia [local] = 4;
			tentativas--;
			atualizar ();
		}
	}
	public int posicao()
	{
		for (i = 0; i < 12; i++) {
			if (livre[i] == 0) {
				livre [i] = 1;
				return i;
			}
		}
		return -1;
	}
	public void atualizar()
	{
		chances.text = tentativas.ToString();
	}
}
