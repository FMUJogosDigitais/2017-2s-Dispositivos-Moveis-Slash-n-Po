using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainController : MonoBehaviour {

	public character player;
	public character enemy;
	public enemyAI enemy_AI;
	public Image player_energy;
	public Image enemy_energy;
	public Text timer;
	public Image ballon;
	public GameObject rock;
	public GameObject paper;
	public GameObject scisor;

	int game_status=1;
	float time = 60f;

	//TODO: musica e efeitos sonoros


	void Start () {
		//Primeira fase, config inicial
		player.initialize(1,3);
		enemy.initialize(2,3);		
	}	
	
	void Update () {
		processaTempo();
		
	}

	public int getGameStatus(){
		return game_status;
	}

	public void playerAttack(int a){		
		player.attack(a);
		int e = enemy_AI.getCurrentAttack();		
		enemy.attack(e);
	}

	public void pauseGame(){
		Debug.Log("Pause");
	}

	public void setBallon(int b){
		rock.SetActive(false);
		paper.SetActive(false);
		scisor.SetActive(false);
		if(b==1)
			rock.SetActive(true);
		else if(b==2)
			paper.SetActive(true);
		else if(b==3)
			scisor.SetActive(true);
	}


	void processaTempo(){
		time -= Time.deltaTime*1;
		float t = Mathf.Floor(time);		
		if(t<0)
			t=0;
		timer.text = ""+t;

	}
}
