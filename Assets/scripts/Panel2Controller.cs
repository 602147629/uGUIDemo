using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Panel2Controller : MonoBehaviour {
    GameObject waku_lower1;
    GameObject waku_lower2;

    private Vector3 waku1Position;
    private Vector3 waku2Position;
    private Vector3 waku1TargetPosition;
    private Vector3 waku2TargetPosition;

    // Use this for initialization
    void Start ()
    {
        waku_lower1 = GameObject.Find("waku_lower1");//左側のパネル
        waku_lower2 = GameObject.Find("waku_lower2");//右側のパネル

        waku1Position = waku_lower1.transform.position;
        waku2Position = waku_lower2.transform.position;
    }

    public void Panel2RightBtnAction()
    {
        waku1TargetPosition = waku1Position;
        waku1TargetPosition.x -= Screen.width;
        waku2TargetPosition = waku2Position;
        waku2TargetPosition.x -= Screen.width;
       
        RectTransform rectTransformL = waku_lower1.GetComponent<RectTransform>();
        rectTransformL.DOMove(waku1TargetPosition, 0.5f);

        RectTransform rectTransformR = waku_lower2.GetComponent<RectTransform>();
        rectTransformR.DOMove(waku2TargetPosition, 0.5f);
    }

    public void Panel2LeftBtnAction()
    {
        waku1TargetPosition = waku1Position;
        waku2TargetPosition = waku2Position;

        RectTransform rectTransformL = waku_lower1.GetComponent<RectTransform>();
        rectTransformL.DOMove(waku1TargetPosition, 0.5f);

        RectTransform rectTransformR = waku_lower2.GetComponent<RectTransform>();
        rectTransformR.DOMove(waku2TargetPosition, 0.5f);
    }
}
