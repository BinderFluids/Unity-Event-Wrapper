
using System;
using UnityEngine;
using UnityEngine.Events;

namespace EventWrapper
{
    [Serializable]
    public class EventWrapper<T> : EventWrapper
    {
        public event Action<T> onEvent = delegate { };
        [SerializeField] private UnityEvent<T> onUnityEvent;
        
        public virtual void Raise(T arg)
        {
            Invoke();
            onEvent?.Invoke(arg);
            onUnityEvent?.Invoke(arg);
        }
    }

    [Serializable]
    public class EventWrapper
    {
        public event Action onEventNoArgs = delegate { };
        [SerializeField] private UnityEvent onUnityEventNoArgs;
        
        public void Invoke()
        {
            onEventNoArgs?.Invoke();
            onUnityEventNoArgs?.Invoke();
        }
    }
    
}

