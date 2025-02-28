﻿using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    [TextArea]
    public string[] dialogueText;
    public bool priority = false;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.GetComponent<Player>() != null) {
            if(dialogueText.Length > 0) {
                int index = Random.Range(0, dialogueText.Length);
                UIManager.instance.ShowMessage(dialogueText[index], priority);
            }
            Destroy(gameObject);
        }
    }
}
