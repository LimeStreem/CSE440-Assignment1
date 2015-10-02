using UnityEngine;
using System.Collections;

public class ZombieAnimater : MonoBehaviour {

	public Sprite[] sprites;

	public float framePerSecounds;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<Renderer> () as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int)(Time.timeSinceLevelLoad * framePerSecounds);
		index = index % sprites.Length;
		spriteRenderer.sprite = sprites[ index ];
	}
}
