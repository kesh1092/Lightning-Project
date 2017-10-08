using UnityEngine;

/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{
	/// <summary>
	/// 0 - The speed of the ship
	/// </summary>
	public Vector2 speed = new Vector2(25, 25);
	// 1 - Store the movement
	private Vector2 movement;
	private Rigidbody2D rigidBodyComponent;

	//to make enemies stop shooting after my player dying
  private GameObject goParent;// = transform.parent.gameObject;
	
	private GameObject dd;// = transform.parent.parent.gameObject;
	// private Rotate_Disregard_original[] foo1;


	void Awake()
	{
	  // goParent = transform.parent.gameObject;
	
		dd = transform.parent.parent.gameObject;
		   // foo1 = dd.GetComponentsInChildren<Rotate_Disregard_original>();		

	}	
 
	
	void Start()
	{
		// var gameOver2 = FindObjectOfType<GameOverScript>();		
		// gameOver2.ShowButtons();
	}


	void Update()
	{
		// 2 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// 3 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);

				// movement *= Time.deltaTime; //doesnt seem to make a difference. these 2 lines
				// transform.Translate(movement); //site recommends to not use these 2 lines

		// 5 - Shooting
		bool shoot = Input.GetButtonDown("Fire1") | Input.GetButtonDown("Fire2"); // For Mac users, ctrl + arrow is a bad idea

		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null && weapon.CanAttack && weapon.noSafetyOn)
			{				
 			  // foo1.Rot();

			  // Rotate_Disregard_original foo1 = dd.GetComponentInChildren<Rotate_Disregard_original>().Rot();		

				// foreach (Rotate_Disregard_original obj in foo1) //the line the error is pointing to
     {
					// obj.Rot();
 // dd[i].GetComponentInChildren<Rotate_Disregard_original>().Rot();		

     }			  


			  // foo
//			  print("TEST LINE");

				weapon.Attack(false);
 
			}
		}

		// 6 - Make sure we are not outside the camera bounds
		var dist = (transform.position - Camera.main.transform.position).z;
		var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
		var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
		var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
		var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;

		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
			transform.position.z
		);
	}

	void FixedUpdate()
	{
		// 4 - Move the game object
		if (rigidBodyComponent == null) rigidBodyComponent = GetComponent<Rigidbody2D>();
		rigidBodyComponent.velocity = movement;
	}

	// void OnDestroy()
	// {
	// 	// Check that the player is dead, as we is also callled when closing Unity
	// 	HealthScript playerHealth = this.GetComponent<HealthScript>();
	// 	if (playerHealth != null && playerHealth.hp <= 0)
	// 	{

	// 		// Game Over.
	// 		var gameOver = FindObjectOfType<GameOverScript>();
	// 		gameOver.ShowButtons();
	// 	}
	// }

//doesnt work as expected. triggar button makes no difference in box collider component
	// void OnTriggerEnter2D(Collision2D collision)
 

	// void OnCollisionEnter2D(Collision2D collision)
	// {
	// 	bool damagePlayer = false;

	// 	// Collision with enemy
	// 	EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
	// 	if (enemy != null)
	// 	{
	// 		// Kill the enemy
	// 		HealthScript enemyHealth = enemy.GetComponent<HealthScript>();
	// 		if (enemyHealth != null) enemyHealth.Damage(enemyHealth.hp);

	// 		damagePlayer = true;
	// 	}

//		Collision with the boss
//		BossScript boss = collision.gameObject.GetComponent<BossScript>();
//		if (boss != null)
//		{
//			// Boss lose some hp too
//			HealthScript bossHealth = boss.GetComponent<HealthScript>();
//			if (bossHealth != null) bossHealth.Damage(5);
//
//			damagePlayer = true;
//		}

	// 	// Damage the player
	// 	if (damagePlayer)
	// 	{
	// 		HealthScript playerHealth = this.GetComponent<HealthScript>();
	// 		if (playerHealth != null) playerHealth.Damage(1);
	// 	}
	// }


	
}
