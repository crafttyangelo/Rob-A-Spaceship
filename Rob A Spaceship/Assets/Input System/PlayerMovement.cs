using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    //input
    private InputAction move_action;

    //components
    [HideInInspector] public CharacterController controller;
    [HideInInspector] public MeshRenderer rend;

    //movement
    public float speed = 5;
    [HideInInspector] public Vector2 direction = Vector2.zero;
    [HideInInspector] public float y_velocity = 0;
    [HideInInspector] public Vector3 velocity = Vector3.zero;
    [HideInInspector] public Vector2 xz_velocity = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get components
        controller = GetComponent<CharacterController>();
        rend = GetComponent<MeshRenderer>();

        //Find reference to the Move and Jump actions
        move_action = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        //read input into variables
        direction = move_action.ReadValue<Vector2>();
    }
}