using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RightMove : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveX(transform.position.x + 32f, 4f).SetLoops(-1, LoopType.Yoyo);
    }

  
}
