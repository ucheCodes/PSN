namespace PSN_Official.Data
{
    public class State
    {
        public SetAdmin Admin { get; set; } = new SetAdmin(false);
        public SetEdit Edit { get; set; } = new SetEdit(new());
    }
    public class SetAdmin
    {
        public bool IsAdmin { get; }
        public SetAdmin(bool isAdmin)
        {
            IsAdmin = isAdmin;
        }
    }
    public class SetEdit
    {
        public KeyValuePair<int,string> Kvp { get;}
        public SetEdit(KeyValuePair<int,string> kvp)
        {
            Kvp = kvp;
        }
    }
    public class Store : IStore
    {
        private State state = new State();
        public State State()
        {
            return state;
        }
        public void MakeAdmin(bool isAdmin)
        {
            state.Admin = new SetAdmin(isAdmin);
            BroadcastChange();
        }
        public void SetEditValue(int key, string serializedValue)
        {
            state.Edit = new SetEdit(new KeyValuePair<int, string>(key, serializedValue));
        }
        #region Observer Patterns
        private Action? action;

        public void AddStateChangedAction(Action? _action)
        {
            action += _action;
        }
        public void RemoveStateChangedAction(Action? _action)
        {
            action -= _action;
        }
        public void BroadcastChange()
        {
            action?.Invoke();
        }
        #endregion
    }
}
