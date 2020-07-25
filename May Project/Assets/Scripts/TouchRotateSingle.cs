using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotateSingle : MonoBehaviour
{
    private void OnMouseDown()
    {
       if (!GameControlSingle.youWinSingle)
        transform.Rotate(0f, 0f, 90f);
    }
}
