using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour {

  //gene for color
  public float r;
  public float g;
  public float b;
  bool dead = false;
  public float timeToDie = 0;

  //Access to attributes on person class (inspector values)
  SpriteRenderer sRenderer;
  Collider2D sCollider;

  //On mouse down. Unity Method on collider
  void OnMouseDown() {
    dead = true;
    timeToDie = PopulationManager.elapsed;
    Debug.Log("Dead At: " + timeToDie); 
    sRenderer.enabled = false;
    sCollider.enabled = false;
  }

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("Start"); 
    sRenderer = GetComponent<SpriteRenderer>();
    sCollider = GetComponent<Collider2D>();
    sRenderer.color = new Color(r,g,b);
  }

  // Update is called once per frame
  void Update()
  {
      
  }
}
