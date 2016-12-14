﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (SpriteRenderer))]

//Modified by Quentin Wendling & Nathan Urbain 

public class RepeatSpriteBoundary : MonoBehaviour {
	SpriteRenderer sprite;

	void Awake () {

		sprite = GetComponent<SpriteRenderer>();
		Vector2 spriteSize = new Vector2(sprite.bounds.size.x / transform.localScale.x, sprite.bounds.size.y / transform.localScale.y);

		// Generate a child prefab of the sprite renderer
		GameObject childPrefab = new GameObject();
		SpriteRenderer childSprite = childPrefab.AddComponent<SpriteRenderer>();
		childPrefab.transform.position = transform.position;
		childSprite.sprite = sprite.sprite;

		// Loop through and spit out repeated tiles
		GameObject child;
		/*for (int i = 1, l = (int)Mathf.Round(sprite.bounds.size.y); i < l; i++){
			child = Instantiate(childPrefab) as GameObject;
			child.transform.position = transform.position - (new Vector3(0, spriteSize.y, 0) * i);
			child.transform.parent = transform;
		}

		for (int i = 1, l = (int)Mathf.Round (sprite.bounds.size.y); i < l; i++) {*/
			for (int j = 1, k = (int)Mathf.Round (sprite.bounds.size.x); j < k; j++) {
				child = Instantiate (childPrefab) as GameObject;
				child.transform.position = transform.position - (new Vector3 (spriteSize.x * j, 0, 0));
				child.transform.parent = transform;
			}




		// Set the parent last on the prefab to prevent transform displacement
		childPrefab.transform.parent = transform;

		// Disable the currently existing sprite component since its now a repeated image
		sprite.enabled = false;
	}
}