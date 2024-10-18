using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//une fonction est composée de 3 elts

void maFonction(int monlnt)

// void = type
// maFonction = nom
// int monlnt = paramètres optionnel

void Start()

// est une fnc qui se lance lors du demarage




public class test: MonoBehaviour{
    int monInt =5;

    void Start(){
        print(monInt);
        monInt++; // incrementation
        print(monInt);
        monInt += 1;
        print(monInt); 

        // Update la fonction qui se lue a chqe frame (image) en permance

        void Update(){
            print(monInt);


        // awake() avant la Start() , LateUpdate = appelee après chaque Update() par exemple lecture d'une camera, FixedUpdate() = ???


        void OnGUI() // on utilise plus ojrd8

        void maFonction()
        }
        
    }
}


public class test : MonoBehaviour {

    int nombre1 = 5;
    int nombre2 = 7;

    private void Start(){
        maFonction();
    }

    // tant qu'on ajoute pas la fonction start rien ne se fait en principe 

    void maFonction(){

        print("Mon premier nombre est" + nombre1);
        print("Mon deuxieme nombre est" + nombre2);
        print("Le resultat de l'addition est" + (nombre1 + nombre2 ));
        
    }
}




// on essaie de changer les nombres par des parametres 
public class test : MonoBehaviour {

    int nombre1 = 5;
    int nombre2 = 7;

    private void Start(){
        maFonction(8,12);
    }

    void maFonction(int parametre1, int parametre2){

        print("Mon premier nombre est" + parametre1);
        print("Mon deuxieme nombre est" + parametre2);
        print("Le resultat de l'addition est" + (parametre1 + parametre2 ));

        //le parametre est très important         
    }
}

