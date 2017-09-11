using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick(PointerEventData eventData) // 3
	{
		print("I was clicked");
		SceneManager.LoadScene ("BattleScene");
	}

}
