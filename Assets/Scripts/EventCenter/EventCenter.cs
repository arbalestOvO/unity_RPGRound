public class EventCenter : PersistentSingleton<EventCenter>
{
    public EventSO eventSO;

    public void event_trigger(EventTypes et)
    {
        if (eventSO.dic_event.ContainsKey(et))
        {
            eventSO.dic_event[et].Invoke();
        }
    }
}

