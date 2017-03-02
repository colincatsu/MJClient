using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[LuaCallCSharp]
public class EventTriggerListener : MonoBehaviour
{
    [CSharpCallLua]
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate onClick;
	public Button[] _buttons;
    public Toggle[] _toggles;
    public InputField[] _inputField;
//    public VoidDelegate onDown;
//    public VoidDelegate onEnter;
//    public VoidDelegate onExit;
//    public VoidDelegate onUp;
//    public VoidDelegate onSelect;
//    public VoidDelegate onUpdateSelect;

    public static EventTriggerListener Get(GameObject go)
    {
        EventTriggerListener listener = go.GetComponent<EventTriggerListener>();
        if (listener == null) listener = go.AddComponent<EventTriggerListener>();
        return listener;
    }
	void Awake(){
        
        _buttons = GetComponentsInChildren<Button> ();
        _toggles = GetComponentsInChildren<Toggle>();
        _inputField = GetComponentsInChildren<InputField>();
        foreach (var item in _buttons)
        {
            Button btn = item;
            btn.onClick.AddListener(delegate ()
            {
                //Debug.Log(item.gameObject.name);
                this.onClick(btn.gameObject);
            });
        }

        foreach (var item in _toggles)
        {
            Toggle btn = item;
            btn.onValueChanged.AddListener(delegate (bool value)
            {
                //				Debug.Log(item.gameObject.name);
                this.onClick(btn.gameObject);
            });
        }

        foreach (var item in _inputField)
        {
            InputField btn = item;
            btn.onValueChanged.AddListener(delegate (string value)
            {
                //				Debug.Log(item.gameObject.name);
                this.onClick(btn.gameObject);
            });
        }
    }

	//	public void onClick (GameObject sender){}
//	protected abstract void OnClickButton(GameObject sender);
//    public override void OnPointerClick(PointerEventData eventData)
//    {
//        if (onClick != null) onClick(gameObject);
//    }
//    public override void OnPointerDown(PointerEventData eventData)
//    {
//        if (onDown != null) onDown(gameObject);
//    }
//    public override void OnPointerEnter(PointerEventData eventData)
//    {
//        if (onEnter != null) onEnter(gameObject);
//    }
//    public override void OnPointerExit(PointerEventData eventData)
//    {
//        if (onExit != null) onExit(gameObject);
//    }
//    public override void OnPointerUp(PointerEventData eventData)
//    {
//        if (onUp != null) onUp(gameObject);
//    }
//    public override void OnSelect(BaseEventData eventData)
//    {
//        if (onSelect != null) onSelect(gameObject);
//    }
//    public override void OnUpdateSelected(BaseEventData eventData)
//    {
//        if (onUpdateSelect != null) onUpdateSelect(gameObject);
//    }
}