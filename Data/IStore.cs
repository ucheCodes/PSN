namespace PSN_Official.Data
{
    public interface IStore
    {
        void AddStateChangedAction(Action? _action);
        void BroadcastChange();
        void MakeAdmin(bool isAdmin);
        void RemoveStateChangedAction(Action? _action);
        void SetEditValue(int key, string serializedValue);
        State State();
    }
}