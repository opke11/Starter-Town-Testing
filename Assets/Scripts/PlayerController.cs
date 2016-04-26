using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Renderer rend;

    [Range(0.0f,1.0f)]
    public float fadeAmount = 0.1f;

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
        rend.material.color = Color.Lerp(Color.red,Color.green,fadeAmount);
	}
}
