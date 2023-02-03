public class Example
{
    public FiniteStateMachine FSM = new FiniteStateMachine();

    void ExampleMethod()
    {
        FSM.Add(0, new ExampleState(FSM));
    }
}

public class ExampleState : State
{
    public ExampleState(FiniteStateMachine fsm) : base(fsm) { }

    public ovveride void Enter() { }
    public ovveride void Exit() { }
    public ovveride void Update() { }
    public ovveride void FixedUpdate() { }
    public ovveride void LateUpdate() { }
}
