using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private Animator animator;
	private CharacterController characterController;

	private float gravity;
	private float jumpSpeed;

	Vector3 moveVelocity;

	//   [SerializeField] private bool isAttacking;

	//   [SerializeField] Transform attackCenter;
	//[SerializeField] float attackRange;
	//   [SerializeField] LayerMask enemyLayers;

	//[SerializeField] private PlayerStats playerStats;

	//   [SerializeField] private AudioSource walkingSound;
	//   [SerializeField] private AudioSource attackSound;
	//   [SerializeField] private AudioSource easterEggSound;
	//   [SerializeField] private AudioSource rockSound;
	//   [SerializeField] private AudioSource woodSound;

	private float nextAttackTimer;

	[SerializeField] private GameObject MainCamera;

	private void Start()
	{
		characterController = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		//attackRange = 1f;
		nextAttackTimer = 0f;
		gravity = 14f;
		jumpSpeed = 6;
		speed = 2f;
	}

	void Update()
	{
		var hInput = 0f;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			hInput = -1f;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			hInput = 1f;
		}

		if (characterController.isGrounded)
		{
			moveVelocity = new Vector3(hInput * speed, moveVelocity.y, 0f);

			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				moveVelocity.y = jumpSpeed;
			}
		}
		else
		{
			moveVelocity.y -= gravity * Time.deltaTime;
		}

		characterController.Move(moveVelocity * Time.deltaTime);

		if (hInput < 0 && characterController.isGrounded)
		{
			// Turn left
			transform.rotation = Quaternion.LookRotation(Vector3.left);
		}
		else if (hInput > 0 && characterController.isGrounded)
		{
			// Turn right
			transform.rotation = Quaternion.LookRotation(Vector3.right);
		}

	//if (!isAttacking)
	//{
	//    controller.Move(movementDirection.normalized * speed * Time.deltaTime);
	//}
	//if (!controller.isGrounded)
	//{
	//    controller.Move(Vector3.down * 10f * Time.deltaTime);
	//}
	//if (movementDirection.magnitude > 0 && Time.timeScale != 0)
	//{
	//    animator.SetFloat("Speed", speed);
	//    if (!walkingSound.isPlaying )
	//    {
	//        walkingSound.Play();
	//    }
	//}
	//else
	//{
	//    animator.SetFloat("Speed", 0);
	//    if (walkingSound.isPlaying)
	//    {
	//        walkingSound.Stop();
	//    }
	//}
	//if (horizontalInput > 0)
	//{
	//    animator.SetFloat("hInput", 1);
	//    speed = 3f;
	//}
	//else if (horizontalInput < 0)
	//{
	//    animator.SetFloat("hInput", -1);
	//    speed = 3f;
	//}
	//else
	//{
	//    animator.SetFloat("hInput", 0);
	//}
	//if (verticalInput > 0)
	//{
	//    animator.SetFloat("vInput", 1);
	//    speed = 5f;
	//}
	//else if (verticalInput < 0)
	//{
	//    animator.SetFloat("vInput", -1);
	//    speed = 5f;
	//}
	//else
	//{
	//    animator.SetFloat("vInput", 0);
	//}

	//// Check if the "EasterEgg" animation has stopped
	//if (animator.GetCurrentAnimatorStateInfo(0).IsName("EasterEgg") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
	//{
	//    if (!easterEggSound.isPlaying)
	//    {
	//        easterEggSound.Play();
	//    }
	//}
	//else
	//{
	//    if (easterEggSound.isPlaying)
	//    {
	//        easterEggSound.Stop();
	//    }
	//}


	//if (Time.time >= nextAttackTimer) 
	//{
	//    if (Input.GetMouseButtonDown(0))
	//    {
	//       // Attack();
	//        nextAttackTimer = Time.time + 1f;
	//    }
	//}
	//if ((animator.GetCurrentAnimatorStateInfo(0).IsName("Attack") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= 0.8f)
	//|| (animator.GetCurrentAnimatorStateInfo(0).IsName("PickingUp") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= 0.9f))
	//{
	//    isAttacking = true;
	//}
	//else
	//{
	//    isAttacking = false;
	//}
}

//private void Attack()
//{
//    if (Random.value < 0.5f)
//    {
//        attackSound.Play();
//    }

//    animator.SetTrigger("Attack");

//    Collider[] hitEnemies = Physics.OverlapSphere(attackCenter.position, attackRange, enemyLayers);

//    foreach (Collider enemy in hitEnemies)
//    {
//        //StartCoroutine(DamageAfterDelay(playerStats.SwordDamage, 0.5f));
//        if (enemy != null && (enemy.CompareTag("Rock") || enemy.CompareTag("Small Rock")))
//        {
//            rockSound.Play();
//        }
//        if (enemy != null && (enemy.CompareTag("Tree") || enemy.CompareTag("Small Tree"))) 
//        {
//            woodSound.Play();
//        }
//    }
//}

//private IEnumerator DamageAfterDelay(int damage, float delay)
//{
//    yield return new WaitForSeconds(delay);
//}
//private void OnDrawGizmosSelected()
//{
//    Gizmos.DrawWireSphere(attackCenter.position, attackRange);
//}
private void OnTriggerEnter(Collider other)
    {
           // healthIncreaseCooldown <= 0f && playerStats.Health < 100)
            //playerStats.Health++;
            //healthIncreaseCooldown = 1f / healthIncreaseRate;
        if (other.CompareTag("Camera -x")) 
        {
			Vector3 currentPosition = MainCamera.transform.position;
			currentPosition.x -= 10.41f; // Subtract 20 from the current x position
			MainCamera.transform.position = currentPosition; // Assign the new position back to the camera
		}
		if (other.CompareTag("Camera +x"))
		{
			Vector3 currentPosition = MainCamera.transform.position;
			currentPosition.x += 10.41f; // Subtract 20 from the current x position
			MainCamera.transform.position = currentPosition; // Assign the new position back to the camera
		}
		if (other.CompareTag("Camera -y"))
		{
			Vector3 currentPosition = MainCamera.transform.position;
			currentPosition.y -= 5.8f; // Subtract 20 from the current x position
			MainCamera.transform.position = currentPosition; // Assign the new position back to the camera
		}
		if (other.CompareTag("Camera +y"))
		{
			Vector3 currentPosition = MainCamera.transform.position;
			currentPosition.y += 5.8f; // Subtract 20 from the current x position
			MainCamera.transform.position = currentPosition; // Assign the new position back to the camera
		}
	}
}
