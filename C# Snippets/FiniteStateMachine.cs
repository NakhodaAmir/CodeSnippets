public class FiniteStateMachine
{
    #region Variables
    protected Dictionary<int, State> states;
    protected State currentState;
    protected State previousState;
    #endregion

    #region Constructor
    public FiniteStateMachine()
    {
        states = new Dictionary<int, State>();
        currentState = null;
        previousState = null;
    }
    #endregion

    #region Public Methods
    public void Add(int key, State state)
    {
        states.Add(key, state);
    }

    public State GetState(int key)
    {
        return states[key];
    }

    public State GetPreviousState()
    {
        return previousState;
    }

    public void SetCurrentState(int key)
    {
        SetCurrentState(GetState(key));
    }

    public void SetCurrentState(State state)
    {
        if (currentState != null) currentState.Exit();

        previousState = currentState;

        currentState = state;

        if (currentState != null) currentState.Enter();
    }

    public void Update()
    {
        if(currentState != null) currentState.Update();
    }

    public void FixedUpdate()
    {
        if (currentState != null) currentState.FixedUpdate();
    }

    public void LateUpdate()
    {
        if (currentState != null) currentState.LateUpdate();
    }
    #endregion
}
