using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Material desactivado, activado;
    Renderer renderers;
    public void Start()
    {
        renderers = GetComponent<Renderer>();
        SetMaterial(false);
    }


    public void BottonActivate()
    {
        SetMaterial(true);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void OnPointerEnter()
    {
        StartCoroutine(activador());
    }

    public void OnPointerExit()
    {
        SetMaterial(false);
    }

    IEnumerator activador()
    {
        yield return new WaitForSeconds(3);
        BottonActivate();
    }

    private void SetMaterial(bool gazedAt)
    {
        if (desactivado != null && activado != null)
        {
            renderers.material = gazedAt ? activado : desactivado;
        }
    }
}
