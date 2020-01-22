using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public InventorySlot slot;

    public void OnDrag (PointerEventData eventData)
    {
        transform.position = Input.GetTouch(0).position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(transform.position), Vector2.zero);
        if (hit.collider && hit.collider.CompareTag("DropZone"))
        {
            Debug.Log("Hit it! " + hit.collider.gameObject.name);
            DropZone dropzone = hit.collider.GetComponent<DropZone>();
            if (slot.item != null)
            {
                dropzone.OnDrop(slot.item);
                //slot.UseItem();
            }
        }
        transform.localPosition = Vector3.zero;
    }
}
