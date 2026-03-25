using System;
using UnityEngine;
using UnityEngine.Events;

namespace EventWrapper
{
    [Serializable]
    public class BoolEventWrapper : EventWrapper<bool>
    {
        public event Action onTrue = delegate { };
        public event Action onFalse = delegate { };
        [SerializeField] private UnityEvent onTrueUnityEvent;
        [SerializeField] private UnityEvent onFalseUnityEvent;

        public override void Raise(bool arg)
        {
            base.Raise(arg);
            
            if (arg) onTrue?.Invoke();
            else onFalse?.Invoke();
            
            if (arg) onTrueUnityEvent?.Invoke();
            else onFalseUnityEvent?.Invoke();
        }
    }
}
    