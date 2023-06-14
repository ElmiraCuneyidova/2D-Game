using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] PlayerCollision collisionScript;

    public void ScoreTextUpdate()
    {
        scoreText.text = collisionScript.Score.ToString();
    }
}
