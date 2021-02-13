using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public string sceneName;
    IEnumerator DeathEffect()
    {
        Time.timeScale = 0.4f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        SceneManager.LoadScene(sceneName);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Vehicle")
        {
            GetComponent<Rigidbody2D>().AddForce(transform.forward * 5);
            StartCoroutine(DeathEffect());
        }
    }
}
