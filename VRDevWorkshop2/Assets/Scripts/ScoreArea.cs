using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour
{
    public Text textObject;
    void OnTriggerEnter(Collider otherCollider) {
        textObject.text = "kekw";
    }
}
