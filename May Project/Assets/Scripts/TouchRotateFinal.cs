using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotateFinal : MonoBehaviour
{
    private void OnMouseDown()
    {
       if (!GameControlFinal.youWin)
        transform.Rotate(0f, 0f, 90f);
    }
}
