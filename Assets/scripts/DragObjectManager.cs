using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DragObjectManager : MonoBehaviour {

    /// 外部アクセスできるように設定

	public static DragObjectManager dragManager;
    public static GameObject gameObj;
    public static bool[] isSet = new bool[6];
    public static int dragSelectNum;
    public static List<GameObject> go = new List<GameObject>();
    // Use this for initialization
    void Start () {
        dragManager = this;
    }
    public void Update()
    {

    }

}
