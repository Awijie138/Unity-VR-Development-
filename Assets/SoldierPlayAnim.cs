using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	[RequireComponent(typeof(Collider))]
public class SoldierPlayAnim : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {
		
		anim=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void animSoldierHey(){
		anim.Play("Idle_Shoot");
	}
	public void animSoldierInteract(){
		anim.Play("Die");
	}
	public void animSoldierDefault(){
		anim.Play("Idle_GunMiddle");
	}
	public void animSoldierMove(){
		anim.Play("WalkForward_Shoot");
	}

}
