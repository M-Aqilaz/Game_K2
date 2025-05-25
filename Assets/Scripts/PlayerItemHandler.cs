using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemHandler : MonoBehaviour
{
    public Transform itemSlotRight; // slot senter
    public Transform itemSlotLeft; // slot sekop
    public Transform mouseTarget;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        itemSlotRight.rotation = Quaternion.Euler(0, 0, angle);
        itemSlotLeft.rotation = Quaternion.Euler(0, 0, angle);
    }
}
