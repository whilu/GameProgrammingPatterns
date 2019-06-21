using UnityEngine;

namespace StatePattern
{
    public interface State
    {
        void Handle(KeyCode keyCode);
    }
}
