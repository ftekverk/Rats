using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogueManager : MonoBehaviour {

       public GameObject dialogueBox;
       public Text dialogueText;
       public string[] dialogue;
       public int counter = 0;
       public int dialogueLength;

       public GameObject dialogueBG;

       void Start(){
              dialogueBox.SetActive(false);
              dialogueBG.SetActive(false);
              dialogueLength = dialogue.Length; //allows us test dialogue without an NPC
       }

       void Update(){
              //temporary testing before NPC is created
              // if (Input.GetKeyDown("o")){
              //        dialogueBox.SetActive(true);
              // }
              // if (Input.GetKeyDown("p")){
              //        dialogueBox.SetActive(false);
              //        dialogueText.text = "..."; //reset text
              //        counter = 0; //reset counter
              // }
       }

       public void OpenDialogue(){
              dialogueBox.SetActive(true);
              dialogueText.text = "You want to go to the surface? You'll die trying.";
              dialogueBG.SetActive(true);
       }

       public void CloseDialogue(){
              dialogueBox.SetActive(false);
              dialogueBG.SetActive(false);
              dialogueText.text = ""; //reset text
              counter = 0; //reset counter
       }

       public void LoadDialogueArray(string[] NPCscript, int scriptLength){
              dialogue = NPCscript;
              dialogueLength = scriptLength;
       }

        //function for the button to display next line of dialogue
       public void DialogueNext(){
              if (counter < dialogueLength){
                     dialogueText.text = dialogue[counter];
                     counter +=1;
              }
              else { //when lines are complete:
                     dialogueBox.SetActive(false); //turn off the dialogue display
                     dialogueBG.SetActive(false);
                     dialogueText.text = "..."; //reset text
                     counter = 0; //reset counter
              }
       }

}
