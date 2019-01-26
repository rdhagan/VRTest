﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class for collisions.
/// </summary>
public class Collide : MonoBehaviour {

	public LayerMask requiredLayer;

	protected virtual void OnCollisionEnter(Collision collision) {
		GameObject other = collision.gameObject;
		if (requiredLayer.value == 0 || (requiredLayer.value & (1 << other.layer)) > 0) {
			HandleCollision(collision);
		}
	}

	protected virtual void HandleCollision(Collision collision) {
	}
}