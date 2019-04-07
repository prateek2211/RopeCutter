using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D raycast = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (raycast.collider)
            {
                if (raycast.collider.tag.Equals("Link"))
                {
                    Destroy(raycast.collider.gameObject);
                };
            }
        }
    }
}
