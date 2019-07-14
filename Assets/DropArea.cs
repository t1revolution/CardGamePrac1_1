using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData data)
    {
        Debug.Log(gameObject.name);

        DragObj dragObj = data.pointerDrag.GetComponent<DragObj>();
        if (dragObj != null)
        {
            dragObj.parentTransform = this.transform;
            Debug.Log(gameObject.name + "に" + data.pointerDrag.name + "をドロップ");
            // vsでのバージョン管理を練習するための変更
            // vsでのバージョン管理を練習するための変更2
            // vsでのバージョン管理を練習するための変更3
        }
    }
}

// developブランチのファイルの内容を変更してpushするとmasterのファイルには
// 影響が及ばないことを確認する
