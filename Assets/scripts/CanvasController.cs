using UnityEngine;
using System.Collections;
using DG.Tweening;
public class CanvasController : MonoBehaviour {
    private GameObject black;
    private GameObject panel1;
    private GameObject panel2;

    // Use this for initialization
    void Start () {
        black = GameObject.Find("Canvas/black");
        panel1 = GameObject.Find("Canvas/Panel1");
        panel2 = GameObject.Find("Canvas/Panel2");

        //blackを非表示に
        black.SetActive(false);
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
	
    public void Panel1BtnAction()
    {
        black.SetActive(true);
        black.GetComponent<CanvasGroup>().DOFade(0, 0.0f);
        black.GetComponent<CanvasGroup>().DOFade(1, 1.0f).OnComplete(Panel1To2);
        black.GetComponent<CanvasGroup>().DOFade(1, 1.0f);
    }
    void Panel1To2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        black.GetComponent<CanvasGroup>().DOFade(0, 1.0f).OnComplete(AfterPanel1To2);
    }
    void AfterPanel1To2()
    {
        black.SetActive(false);
    }
}
