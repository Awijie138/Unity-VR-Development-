using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	[RequireComponent(typeof(Collider))]
public class PlayAnim : MonoBehaviour {
	
	public Animator anim;
	// Use this for initialization
	void Start () {
		
		anim=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void animHey(){
		anim.Play("WAIT03/HeyAnim");
	}
	
	public void animDefault(){
		anim.Play("WAIT00");
	}
	
	public void animInteract(){
		anim.Play("DAMAGED00");
	}
	

}
