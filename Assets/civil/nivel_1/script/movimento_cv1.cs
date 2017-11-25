using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class movimento_cv1 : MonoBehaviour {
	public static bool rodar = false;
	bool entrada=true;
	int qtd=0,func=0,delay=0;
	public float x,y,w,h;
	public GameObject[] tela = new GameObject[2];
	public Text resultado;
    public GameObject centro;
    RectTransform rt;
    void Start()
    {
        rt = (RectTransform)centro.transform;

        w = rt.rect.width;
        w /= 10;
        h = rt.rect.height;
        h /= 10;
    }
        void Update () {

		if (rodar) {
			if (func == 0) {
				StartCoroutine ("Tempo");
				func = 1;
			}
			if (compi.sequencia [qtd] == 1 && entrada == true) {
				y = transform.position.y;
				y += h;
				transform.position = new Vector3 (transform.position.x, y, transform.position.z);
				entrada = false;
				qtd++;

			} else if (compi.sequencia [qtd] == 2 && entrada == true) {
				y = transform.position.y;
				y -= h;
				transform.position = new Vector3 (transform.position.x, y, transform.position.z);
				entrada = false;
				qtd++;
			} else if (compi.sequencia [qtd] == 3 && entrada == true) {
				x = transform.position.x;
				x -= w;
				transform.position = new Vector3 (x, transform.position.y, transform.position.z);
				entrada = false;
				qtd++;
			} else if (compi.sequencia [qtd] == 4 && entrada == true) {
				x = transform.position.x;
				x += w;
				transform.position = new Vector3 (x, transform.position.y, transform.position.z);
				entrada = false;
				qtd++;
			} else if (compi.sequencia [qtd] == 0) {
				qtd++;
			} else if (compi.sequencia [qtd] == -1 && delay==0) {
				delay = 1;
				entrada = false;
				
			}
			if(delay== 1 && entrada ==true)
			{
				StopCoroutine ("Tempo");
				func = 0;
				qtd = 0;
				delay = 0;
				rodar = false;
				tela [1].SetActive (true);
				tela [0].SetActive (false);

			}
		}
			
	}
	public IEnumerator Tempo()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			entrada = true;
		}

	}
}
