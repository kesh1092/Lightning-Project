using UnityEngine;

/// <summary>
/// Launch projectile
/// </summary>
public class WeaponScript : MonoBehaviour
{
	//--------------------------------
	// 1 - Designer variables
	//--------------------------------

	/// <summary>
	/// Projectile prefab for shooting
	/// </summary>
	public Transform shotPrefab;  //this is the shot prefab under prefab's
	/// <summary>
	/// Cooldown in seconds between two shots
	/// </summary>
	public float shootingRate = 0.25f;

	//--------------------------------
	// 2 - Cooldown
	//--------------------------------
	public bool noSafetyOn = false;
	private float shootCooldown;

	void Start()
	{
		shootCooldown = 0f;
		noSafetyOn = true;
	}

	void Update()
	{
		if (shootCooldown > 0)
		{
			shootCooldown -= Time.deltaTime;
		}
	}

	void Destroy() //isnt called when script is turned off during runtime
	{
		noSafetyOn = false;
	}

	//--------------------------------
	// 3 - Shooting from another script
	//--------------------------------

	/// <summary>
	/// Create a new projectile if possible
	/// </summary>
	public void Attack(bool isEnemy)
	{
		if (CanAttack)
		{
			shootCooldown = shootingRate;

			// Create a new shot
			var shotTransform = Instantiate(shotPrefab) as Transform;

			// Assign position
			shotTransform.position = transform.position;

			// The is enemy property
			ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
			if (shot != null)
			{
				shot.isEnemyShot = isEnemy; //isEnemy is set to false in PlayerScript
			}

			// Make the weapon shot always towards it
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if (move != null)
			{
				move.direction = this.transform.right; // towards in 2D space is the right of the sprite
			}
		}
	}

	/// <summary>
	/// Is the weapon ready to create a new projectile?
	/// </summary>
	public bool CanAttack
	{
		get
		{
			return shootCooldown <= 0f;
		}
	}
}
	