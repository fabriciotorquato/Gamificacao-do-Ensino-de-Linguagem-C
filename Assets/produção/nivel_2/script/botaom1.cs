using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class botaom1 : MonoBehaviour {
	public float x,y;
	int pos;
	public int cod;
	public GameObject[] local=new GameObject[3];
    void Awake() {
        x = transform.position.x;
		y = transform.position.y;
        pos = -1;
	}

	public void botao()
	{
		if (pos == -1) {
            x = transform.position.x;
            y = transform.position.y;

            if (compilador.m1 [0,0] == 0) {
				compilador.m1 [0,0] = 1;
				compilador.m1 [0, 1] = cod;
				transform.position = local [0].transform.position;
				pos = 0;
			}
			else if (compilador.m1 [1,0] == 0) {
				compilador.m1 [1,0] = 1;
				compilador.m1 [1, 1] = cod;
				pos = 1;
				transform.position = local [1].transform.position;
			}
			else if (compilador.m1 [2,0] == 0) {
				compilador.m1 [2,0] = 1;
				compilador.m1 [2, 1] = cod;
				pos = 2;
				transform.position = local [2].transform.position;
			}
				
		} 
		else {
			compilador.m1 [pos,0] = 0;
			compilador.m1 [pos, 1] = -1;
			pos = -1;
			transform.position = new Vector3 (x,y,transform.position.z);	
		}
	}
	public void m2()
	{
		if (pos == -1) {
            x = transform.position.x;
            y = transform.position.y;
            if (compilador.m2 [0,0] == 0) {
				compilador.m2 [0,0] = 1;
				compilador.m2 [0, 1] = cod;
				transform.position = local [0].transform.position;
				pos = 0;
			}
			else if (compilador.m2 [1,0] == 0) {
				compilador.m2 [1,0] = 1;
				compilador.m2 [1, 1] = cod;
				pos = 1;
				transform.position = local [1].transform.position;
			}
			else if (compilador.m2 [2,0] == 0) {
				compilador.m2 [2,0] = 1;
				compilador.m2 [2, 1] = cod;
				pos = 2;
				transform.position = local [2].transform.position;
			}

		} 
		else {
			compilador.m2 [pos,0] = 0;
			compilador.m2 [pos, 1] = -1;
			pos = -1;
			transform.position = new Vector3 (x,y,transform.position.z);	


		}
	}
	public void m3()
	{
		if (pos == -1) {
            x = transform.position.x;
            y = transform.position.y;
            if (compilador.m3 [0,0] == 0) {
				compilador.m3 [0,0] = 1;
				compilador.m3 [0, 1] = cod;
				transform.position = local [0].transform.position;
				pos = 0;
			}
			else if (compilador.m3 [1,0] == 0) {
				compilador.m3 [1,0] = 1;
				compilador.m3 [1, 1] = cod;
				pos = 1;
				transform.position = local [1].transform.position;
			}
			else if (compilador.m3 [2,0] == 0) {
				compilador.m3 [2,0] = 1;
				compilador.m3 [2, 1] = cod;
				pos = 2;
				transform.position = local [2].transform.position;
			}

		} 
		else {
			compilador.m3 [pos,0] = 0;
			compilador.m3 [pos, 1] = -1;
			pos = -1;
			transform.position = new Vector3 (x,y,transform.position.z);	


		}
	}
}
