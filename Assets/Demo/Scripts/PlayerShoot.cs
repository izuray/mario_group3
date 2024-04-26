using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab của đạn
    public Transform firePoint; // Vị trí bắn đạn
    public float bulletForce = 20f; // Lực bắn đạn
    public int bulletDamage = 1; // Sát thương gây ra bởi viên đạn

    // Update is called once per frame
    void Update()
    {
        // Kiểm tra nếu nút F được nhấn
        if (Input.GetKeyDown(KeyCode.M))
        {
            Shoot(); // Bắn đạn
        }
    }

    void Shoot()
    {
        // Tạo một đạn mới từ prefab
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Lấy component Rigidbody2D của đạn
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Kiểm tra xem Rigidbody2D có tồn tại không
        if (rb != null)
        {
            // Áp dụng lực để bắn đạn
            rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        }
    }
}