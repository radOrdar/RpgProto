using Combat;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1;

    private Armament armament;

    private Camera mainCamera;
    private InputActions actions;
    private Vector2 moveInput;
    private Vector2 aimInput;

    private void Awake()
    {
        armament = GetComponent<Armament>();
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        actions = new InputActions();
        actions.Enable();

        actions.KeyboardMouse.Move.performed += HandleMove;
        actions.KeyboardMouse.Move.canceled += HandleMove;
        actions.KeyboardMouse.Aim.performed += HandleAim;
        actions.KeyboardMouse.Shoot.performed += HandleShoot;
        actions.KeyboardMouse.OnKey1.performed += HandleKey1;
        actions.KeyboardMouse.OnKey2.performed += HandleKey2;
        actions.KeyboardMouse.OnMouseScroll.performed += HandleMouseScroll;
    }

    private void OnDisable()
    {
        actions.Disable();
    }

    private void Update()
    {
        transform.Translate(moveInput * moveSpeed * Time.deltaTime);

        var mouseWorld = mainCamera.ScreenToWorldPoint(aimInput);
        mouseWorld.z = 0;
        transform.up = (mouseWorld - transform.position).normalized;
    }

    #region Input handlers

    private void HandleMouseScroll(InputAction.CallbackContext ctx)
    {
        armament.MouseScroll((int)ctx.ReadValue<Vector2>().y);
    }

    private void HandleKey1(InputAction.CallbackContext ctx)
    {
        armament.KeyPressed(1);
    }

    private void HandleKey2(InputAction.CallbackContext ctx)
    {
        armament.KeyPressed(2);
    }

    private void HandleShoot(InputAction.CallbackContext ctx)
    {
        armament.UseWeapon();
    }

    private void HandleAim(InputAction.CallbackContext ctx)
    {
        aimInput = ctx.ReadValue<Vector2>();
    }

    private void HandleMove(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
    }

    #endregion
}