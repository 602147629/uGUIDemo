using UnityEngine;
using UnityEngine.EventSystems;

public class DropObject : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData e)
    {
        DragObjectManager.dragSelectNum = int.Parse(gameObject.name.Substring(4, 1)) - 1;
        if (DragObjectManager.isSet[DragObjectManager.dragSelectNum]!=true) { 
            DragObjectManager.gameObj.transform.position = transform.position;
            DragObjectManager.isSet[DragObjectManager.dragSelectNum] = true;
            DragObjectManager.go.Add(DragObjectManager.gameObj);
            DragObjectManager.gameObj.transform.parent = GameObject.Find("waku_up").transform;
        }
    }
    public void Update()
    {

    }
}