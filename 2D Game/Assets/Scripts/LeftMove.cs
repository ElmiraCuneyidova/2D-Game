using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LeftMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(transform.position.x - 27f, 3f).SetLoops(-1, LoopType.Yoyo);
    }

  
}
