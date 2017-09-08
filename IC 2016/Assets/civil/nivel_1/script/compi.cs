using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class compi : MonoBehaviour {
	public static int x,y;
	public int xa,ya;
	int i;
	public static int[] sequencia=new int[13];

	void Start () {
		x = 0;
		y = 0;
		for (i = 0; i < 13; i++) {
			sequencia [i] = -1;
		}
	}
	void Update () {
	    	xa = x;
            ya = y;

	}


}
