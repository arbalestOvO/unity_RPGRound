using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
[ManageableData]
[CreateAssetMenu(fileName = "EventSO", menuName = "ScriptableObjects/EventSO")]
public class EventSO : ScriptableObject
{
    [SerializeField] public SerializedDictionary<EventTypes, UnityEvent> dic_event;
}
public class ManageableDataAttribute : Attribute
{
}