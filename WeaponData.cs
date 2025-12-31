using UnityEngine;

[CreateAssetMenu(menuName = "Duelz/Weapon")]
public class WeaponData : ScriptableObject
{
    public string weaponName;
    public int damage;
    public float fireRate;
    public int magazineSize;
    public float reloadTime;
    public float recoil;
    public float range;
    public bool hitscan;
    public GameObject projectilePrefab;
}
