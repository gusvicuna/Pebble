using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mygames.supertelegram;

public interface IExplotable
{
    public void Explotar();
}

public class Caja : IExplotable
{
    int daño;
    void IExplotable.Explotar()
    {
        // Definir como explota la caja
    }
    
    //Metodo que se puede modificar en clases hijas. Debe llevar "virtual".
    protected virtual void DañarAlrededor()
    {
        //Hacer algo con el daño...
    }
}

public class CajaElemental : Caja
{
    public element tipoElemento;

    //Metodo proveniente de Caja el cual modificamos
    protected override void DañarAlrededor()
    {
        //Hacemos lo mismo que está en Caja
        base.DañarAlrededor();
        
        //Hacemos algo más con el elemento...
        
    }
}
