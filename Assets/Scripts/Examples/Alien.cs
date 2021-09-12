using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using mygames.supertelegram;


public class Alien
{
    //Las clases son un objeto de referencia
    /* Alien nuevoAlien = antiguoAlien
     * nuevoAlien.myName = "Jeff" 
     * antiguoAlien.myName == "Jeff" --> True*/

    #region Constants

    //atributo que no puede ser cambiado
    const double PI = 3.14;

    #endregion


    #region Public Attributes

    // enums:
    public element miElementoPrincipal = element.fire; //Se puede tener una variable del tipo enum ya creado
    public int miDaño = (int) difficulty.medium; //Se puede convertir el enum a int

    #endregion


    #region Private Attributes

    //Los atributos privados no pueden ser accedidos por otras clases. SOLO por esta.

    private string name; //Los atributos pueden ser declarados sin ser inicializados con algun valor.
    private string[] lastNames = new string[2] {"González", "Pérez" }; //array inicializado
    private int[,] matriz = new int[,] { { 1, 0 }, { 1, 2 } }; //matriz inicializada   matriz[0,1] --> 0

    //Los atributos con acceso "protected" otras clases no pueden accederlo a excepción de las que hereden de esta clase.
    protected bool isJumping = false;

    #endregion


    #region Public Methods

    //Constructor
    public Alien(string name, element elementoPrincipal = element.fire)
    {
        this.name = name;
        this.miElementoPrincipal = elementoPrincipal;
        this.isJumping = false;
    } 

    #endregion


    #region Private Methods

    private void Metodo1()
    {
        //hacer algo sin retornar
    }

    private bool Metodo2(bool checkeo)
    {
        //Ya que el metodo retorna un bool, DEBE tener un "return x", siendo x un bool
        return !checkeo;
    }

    private static void Metodo3(element elemento, int vida)
    {
        //Hacer algo que todas las instancias hacen por igual

        if (elemento.Equals(element.fire))
        {
            //Hacer algo
        }

        switch (elemento)
        {
            case element.fire:
                //Hacer algo
                break;
            case element.water:
                //Hacer otra cosa...
                break;
        }

        while (vida >= 0)
        {
            //Hacer algo checkeando antes la vida por primera vez
        }

        do
        {
            //Hacer algo checkeando después la vida por primera vez
        } while (vida >= 0);


    }

    #endregion
}

public struct Monster
{
    //Las estructuras son un objeto de valor
    /* Monster nuevoMonster = antiguoMonster
     * nuevoMonster.myName = "Jeff" 
     * antiguoMonster.myName == "Jeff" --> False*/

    public Alien dueño;

}
