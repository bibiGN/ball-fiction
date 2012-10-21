using UnityEngine;
using System.Collections;

/// <summary>
/// Script général de comportement d'un bouton qui est activé/désactivé quand on appuie dessus
/// </summary>
public class StopBallScript : PonctualButtonScript {
	// Use this for initialization
	void Start () {
		if(this._theBall == null) {
			Utils.WarningMessageWhenNoGameObjectAssigned("ball", this.GetType().ToString(), this.gameObject.name);
		}
	}
	
	// Update is called once per frame
	void Update () {}
	
//	void OnTriggerStay(Collider collider) {
//		this.ActionWhenActivated();
//	}
	
	override protected void ActionWhenActivated() {
		if(this._theBall != null) {
			this._theBall.rigidbody.velocity = Vector3.zero;
			this._theBall.rigidbody.angularVelocity = Vector3.zero;
		}
	}
	
	override protected void ActionWhenNonActivated() {
		this.ActionWhenActivated();
	}
}