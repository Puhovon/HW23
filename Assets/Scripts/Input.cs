using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Input : MonoBehaviour
{
    private Vector3 movement;
    private Movement script;
    private static int currentWeapon { get; set; } = 1;
    private Animations _animations;
    [SerializeField] private List<GameObject> weapons;
    private void Awake()
    {
        script = GetComponent<Movement>();
        _animations = GetComponent<Animations>();
        print(weapons.Count);

            
    }

    private void Update()
    {
        float vertical = UnityEngine.Input.GetAxis("Vertical");
        float horizontal = UnityEngine.Input.GetAxis("Horizontal");

        if (UnityEngine.Input.GetAxis("Mouse ScrollWheel") >= 0.1)
        {
            print(UnityEngine.Input.GetAxis("Mouse ScrollWheel"));
            weapons[currentWeapon].SetActive(false);
            if (currentWeapon == weapons.Count - 1)
                currentWeapon = 0;
            else
                currentWeapon++;

            weapons[currentWeapon].SetActive(true);
            print(currentWeapon);
            print(weapons[currentWeapon].name);
        }

        if (UnityEngine.Input.GetAxis("Mouse ScrollWheel") <= -0.1)
        {
            print(UnityEngine.Input.GetAxis("Mouse ScrollWheel"));

            weapons[currentWeapon].SetActive(false);
            if (currentWeapon == 0)
                currentWeapon = weapons.Count - 1;
            else
                currentWeapon--;

            weapons[currentWeapon].SetActive(true);
            print(currentWeapon);
            print(weapons[currentWeapon].name);
        }

        movement = new Vector3(horizontal, 0, vertical);
        
        if(UnityEngine.Input.GetButton("Fire1"))
            _animations.Attack("MainAttack");
        if(UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
            _animations.Attack("SecondAttack");
    }

    private void FixedUpdate()
    {
        script.Move(movement);
    }
}
