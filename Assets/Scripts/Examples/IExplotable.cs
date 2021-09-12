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
    int da�o;
    void IExplotable.Explotar()
    {
        // Definir como explota la caja
    }
    
    //Metodo que se puede modificar en clases hijas. Debe llevar "virtual".
    protected virtual void Da�arAlrededor()
    {
        //Hacer algo con el da�o...
    }
}

public class CajaElemental : Caja
{
    public element tipoElemento;

    //Metodo proveniente de Caja el cual modificamos
    protected override void Da�arAlrededor()
    {
        //Hacemos lo mismo que est� en Caja
        base.Da�arAlrededor();
        
        //Hacemos algo m�s con el elemento...
        
    }
}
