using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DownMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(transform.position.y - 14f, 3f).SetLoops(-1, LoopType.Yoyo);
    }

 
}
