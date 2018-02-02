
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour {
	public Transform pause_Canvas;
	public Transform Buttons;
	public Transform Player;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			PauseGame ();
		}
	}



	public void PauseGame() {
		if (pause_Canvas.gameObject.activeInHierarchy == false) {
			pause_Canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
            Player.GetComponent<ProjectileDraggingScript>().enabled = false;

		} else {
			pause_Canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
            Player.GetComponent<ProjectileDraggingScript>().enabled = true;

        }
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Player.GetComponent<ProjectileDraggingScript>().enabled = true;
        SceneManager.LoadScene("AngryScene");
    }
}