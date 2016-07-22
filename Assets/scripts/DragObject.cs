using UnityEngine;
using UnityEngine.EventSystems;
 
public class DragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public bool isDrop = false;
    public Vector3 startPosition;
    public void OnBeginDrag(PointerEventData e)
    {
        DragObjectManager.gameObj = gameObject;
        startPosition= gameObject.transform.position;
        
        CanvasGroup canvasGroup = gameObject.GetComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = false;
        gameObject.transform.SetAsLastSibling();
    }
    public void Update()
    {

    }
    public void OnDrag(PointerEventData e)
    {
        DragObjectManager.gameObj.transform.position = e.position;
    }

    public void OnEndDrag(PointerEventData e)
    {
        //登録したオブジェクトに含まれていなかったら戻す
        foreach (GameObject go in DragObjectManager.go) {
            Debug.Log(gameObject.name);
            if (go == this.gameObject) return;
        }
        DragObjectManager.gameObj.transform.position= startPosition;
        CanvasGroup canvasGroup = DragObjectManager.gameObj.GetComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = true;
        DragObjectManager.gameObj.transform.SetAsFirstSibling();
    }
}