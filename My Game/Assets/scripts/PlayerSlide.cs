using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerSlide: MonoBehaviour {
    public bool slide = false;
    [SerializeField]
    Collider2D PolyCollider;
    Animator anim;
    // Use this for initialization
    private void Start () {
        anim = GetComponent<Animator>();

    }
  
    // Update is called once per frame
    void Update () {
        PolyCollider.enabled = !slide;
        anim.SetBool("slide", slide);

    }

    public void startSlide()
    {
        slide = true; 
    }
    public void stopSlide()
    {
        slide = false;
    }



}
