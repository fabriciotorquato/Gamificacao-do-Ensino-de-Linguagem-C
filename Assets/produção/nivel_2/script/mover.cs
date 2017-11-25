using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {
	public int peso;
	public Animator anim;
	int x1,x2,op,i,cod;

	void Start () {
		anim = GetComponent <Animator>();
		producao_nvl2_comp (compilador.m1);
		if (op == 1) {
			if (x1 > x2) {
			anim.SetBool("caminhoA",true);
			} 
		} else if (op == 2) {
			if (x1 >= x2) {
				anim.SetBool("caminhoA",true);
			} 
		}
		else if (op == 3) {
			if (x1 < x2) {
				anim.SetBool("caminhoA",true);
			}
		}
		else if (op == 4) {
			if (x1 <= x2) {
				anim.SetBool("caminhoA",true);
			} 
		}
		producao_nvl2_comp (compilador.m2);
		if (op == 1) {
			if (x1 > x2) {
				anim.SetBool("CaminhoB",true);
			} 
		} else if (op == 2) {
			if (x1 >= x2) {
				anim.SetBool("CaminhoB",true);
			} 
		}
		else if (op == 3) {
			if (x1 < x2) {
				anim.SetBool("CaminhoB",true);
			}
		}
		else if (op == 4) {
			if (x1 <= x2) {
				anim.SetBool("CaminhoB",true);
			} 
		}
		producao_nvl2_comp (compilador.m3);
		if (op == 1) {
			if (x1 > x2) {
				anim.SetBool("CaminhoC",true);
			} 
		} else if (op == 2) {
			if (x1 >= x2) {
				anim.SetBool("CaminhoC",true);
			} 
		}
		else if (op == 3) {
			if (x1 < x2) {
				anim.SetBool("CaminhoC",true);
			}
		}
		else if (op == 4) {
			if (x1 <= x2) {
				anim.SetBool("CaminhoC",true);
			} 
		}
		anim.SetBool("inicio",true);
	}

	public void producao_nvl2_comp(int [,]m)
	{
		switch (m[0,1]) {
		case 1:
			x1 = peso;
			break;
		case 6:
			x1 = 3;
			break;
		case 7:
			x1 = 7;
			break;
		case 8:
			x1 = 12;
			break;
		default:
			x1 = -1;
			break;
		}
		switch (m[2,1]) {
		case 1:
			x2 = peso;
			break;
		case 6:
			x2 = 3;
			break;
		case 7:
			x2 = 7;
			break;
		case 8:
			x2 = 12;
			break;
		default:
			x2 = -1;
			break;
		}
		switch (m[1,1]) {
		case 2:
			op = 1;
			break;
		case 3:
			op = 2;
			break;
		case 4:
			op = 3;
			break;
		case 5:
			op = 4;
			break;
		default:
			op = -1;
			break;
		}
	}
}
