using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using XLua;

[LuaCallCSharp]
public class AnimationRegister : MonoBehaviour {
    [CSharpCallLua]
    public delegate void VoidDelegate();
    public VoidDelegate animationEvent;
	// Use this for initialization
	void Start () {
        //gameObject.GetComponent<Animation>().clip.Play("GaiDown");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void animationListener() {
        if (animationEvent != null)
            animationEvent();
    }
}
