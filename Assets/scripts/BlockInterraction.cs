using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInterraction : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        }
    }
}
